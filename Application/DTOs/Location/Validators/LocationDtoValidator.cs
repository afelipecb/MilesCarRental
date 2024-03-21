using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Location.Validators
{
    public class LocationDtoValidator : AbstractValidator<LocationDto>
    {
        public LocationDtoValidator() {
            
            RuleFor(x=>x.NameLocation)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");

            RuleFor(x => x.Adress)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");
        }
    }
}
