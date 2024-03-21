using Application.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Requests.Commands
{
    public class UpdateUserCommand : IRequest<UserDto>
    {
        public UserDto UserDto { get; set; }
    }
}
