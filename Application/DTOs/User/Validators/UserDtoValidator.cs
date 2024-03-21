using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.User.Validators
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x=>x.Name)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");

            RuleFor(x => x.DocumentId)
                .NotEmpty().WithMessage("{PropertyName} does not exist.");
        }
    }
}
