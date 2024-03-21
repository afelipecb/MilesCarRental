using Application.DTOs.User;
using Application.Features.Users.Requests.Commands;
using Application.Features.Users.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MilesCarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: UserController
        [HttpGet("GetUserById")]
        public async Task<ActionResult<UserDto>> Get(int id)
        {
            var user = await _mediator.Send(new GetUserRequest() { Id = id });

            return user;
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<UserDto>> Post(CreateUserDto userInfo)
        {
            var user = await _mediator.Send(new CreateUserCommand() { CreateUserDto = userInfo });

            return Ok(user);
        }

        [HttpPut("UpdateUserInfo")]
        public async Task<ActionResult<UserDto>> Put(UserDto userInfo)
        {
            var user = await _mediator.Send(new UpdateUserCommand() { UserDto = userInfo });

            return user;
        }

        [HttpDelete("DeleteUserById")]
        public async Task<ActionResult<bool>> Delete(int userId)
        {
            var success = await _mediator.Send(new DeleteUserCommand() { Id = userId });

            return Ok();
        }
    }
}
