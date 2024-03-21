using Application.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Requests.Commands
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public CreateUserDto  CreateUserDto { get; set; }
    }
}
