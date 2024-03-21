using Application.Contracts.Persistance;
using Application.Features.Cars.Requests.Commands;
using Application.Responses;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Cars.Handlers.Commands
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, BaseCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public DeleteCarCommandHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            if(!await _carRepository.ExistAsync(request.Id))
            {
                response.Success = false;
                response.Message = "Delete Car Failed";
                response.Errors = new List<string> { "El carro no existe" };

                return response;
            }

            await _carRepository.DeleteAsync(await _carRepository.GetAsync(request.Id));

            return response;
        }
    }
}
