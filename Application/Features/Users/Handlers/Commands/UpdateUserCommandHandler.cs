using Application.Contracts.Persistance;
using Application.DTOs.User.Validators;
using Application.DTOs.User;
using Application.Features.Users.Requests.Commands;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Users.Handlers.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new UserDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.UserDto);

            if (!validatorResult.IsValid)
            {
                throw new Exception();
            }

            var user = await _userRepository.GetAsync(request.UserDto.Id);

            if (user == null)
            {
                throw new Exception();
            }

            _mapper.Map(request.UserDto, user);

            user = await _userRepository.UpdateAsync(user);
            var userdto = _mapper.Map<UserDto>(user);

            return userdto;
        }
    }
}
