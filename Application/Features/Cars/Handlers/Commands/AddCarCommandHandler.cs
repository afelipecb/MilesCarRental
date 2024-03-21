using Application.Contracts.Persistance;
using Application.DTOs.Car.Validators;
using Application.Features.Cars.Requests.Commands;
using Application.Responses;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Cars.Handlers.Commands
{
    internal class AddCarCommandHandler : IRequestHandler<AddCarCommand, BaseCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly ILocationRepository _locationRepository;

        public AddCarCommandHandler(ICarRepository carRepository, IMapper mapper, ILocationRepository locationRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _locationRepository = locationRepository;
        }

        public async Task<BaseCommandResponse> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            var response=new BaseCommandResponse();
            var validator = new CarDtoValidator(_locationRepository);
            var validatorResult = await validator.ValidateAsync(request.CarDto);

            if (!validatorResult.IsValid)
            {
                response.Success = false;
                response.Message = "Create Car Failed";
                response.Errors = validatorResult.Errors.Select(q => q.ErrorMessage).ToList();

                return response;
            }

            var exists = await _carRepository.ExistAsync(request.CarDto.NumberPlate);

            if(exists)
            {
                response.Success = false;
                response.Message = "Create Car Failed";
                response.Errors = new List<string> { "El carro ya existe" };

                return response;
            }

            var car = _mapper.Map<Car>(request.CarDto);
            car.AddCar();

            car = await _carRepository.AddAsync(car);

            response.Message = "Carro creado con exito";
            return response;
        }
    }
}
