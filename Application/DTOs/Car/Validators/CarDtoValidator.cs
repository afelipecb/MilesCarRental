using Application.Contracts.Persistance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Car.Validators
{
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        private readonly ILocationRepository _locationRepository;

        public CarDtoValidator(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;

            RuleFor(x => x.LocationId)
                .NotEmpty().WithMessage("Location Id is empty")
                .MustAsync(async (id, cancelationToken) =>
                {
                    return await _locationRepository.ExistAsync(id);
                }).WithMessage("Location Id does not exist");

            RuleFor(x => x.Brand)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.Model)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.Year)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.Color)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.SeatNumber)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.GearBox)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.NumberPlate)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            RuleFor(x => x.LocationId)
                .NotEmpty().WithMessage("{PropertyName} does not exist");
            
        }
    }
}
