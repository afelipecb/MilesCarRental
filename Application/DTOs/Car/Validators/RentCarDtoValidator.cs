using Application.Contracts.Persistance;
using Application.DTOs.Car;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Car.Validators
{
    public class RentCarDtoValidator : AbstractValidator<RentCarDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly ILocationRepository _locationRepository;

        public RentCarDtoValidator(IUserRepository userRepository, ILocationRepository locationRepository)
        {
            _userRepository = userRepository;
            _locationRepository = locationRepository;

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Car Id is empty");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("User Id is empty")
                .MustAsync(async (id, cancelationToken) =>
                {
                    return await _userRepository.ExistAsync(id);
                }).WithMessage("User Id does not exist");

            RuleFor(x => x.LocationId)
                .NotEmpty().WithMessage("Location Id is empty")
                .MustAsync(async (id, cancelationToken) =>
                {
                    return await _locationRepository.ExistAsync(id);
                }).WithMessage("Location Id does not exist");
        }
    }
}
