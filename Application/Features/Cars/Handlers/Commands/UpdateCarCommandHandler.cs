using Application.Contracts.Persistance;
using Application.DTOs.Car;
using Application.DTOs.Car.Validators;
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
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, BaseCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepository;

        public UpdateCarCommandHandler(ICarRepository carRepository, IMapper mapper, ILocationRepository locationRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _locationRepository = locationRepository;
        }

        public async Task<BaseCommandResponse> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var response=new BaseCommandResponse();
            var validator = new UpdateCarDtoValidator(_locationRepository);
            var validatorResult = await validator.ValidateAsync(request.updateCarDto);

            if (!validatorResult.IsValid)
            {
                response.Success = false;
                response.Message = "Update Car Failed";
                response.Errors = validatorResult.Errors.Select(q => q.ErrorMessage).ToList();
                return response;
            }

            var car = await _carRepository.GetAsync(request.updateCarDto.Id);

            if (car == null)
            {
                response.Success = false;
                response.Message = "Update Car Failed";
                response.Errors = new List<string> { "El carro no existe" };

                return response;
            }

            _mapper.Map(request.updateCarDto, car);

            car = await _carRepository.UpdateAsync(car);
            var cardto = _mapper.Map<GetCarDto>(car);

            response.Message = "Carro actualizado con exito";
            return response;
        }
    }
}
