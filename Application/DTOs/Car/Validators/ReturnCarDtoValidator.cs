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
    public class ReturnCarDtoValidator : AbstractValidator<ReturnCarDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly ILocationRepository _locationRepository;

        public ReturnCarDtoValidator(IUserRepository userRepository, ILocationRepository locationRepository)
        {

            _userRepository = userRepository;
            _locationRepository = locationRepository;

            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Car Id is empty");
        }
    }
}
