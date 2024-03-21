using Application.Contracts.Persistance;
using Domain;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.Cars.Requests.Commands;
using Application.DTOs.Car.Validators;
using Application.DTOs.Car;
using Application.Responses;


namespace Application.Features.Cars.Handlers.Commands
{
    public class RentCarCommandHandler : IRequestHandler<RentCarCommand, BaseCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly ILocationRepository _locationRepository;

        public RentCarCommandHandler(ICarRepository carRepository, IMapper mapper, IUserRepository userRepository, ILocationRepository locationRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _locationRepository = locationRepository;
        }

        public async Task<BaseCommandResponse> Handle(RentCarCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var validator = new RentCarDtoValidator(_userRepository, _locationRepository);
            var validatorResult = await validator.ValidateAsync(request.RentCarDto);

            if(!validatorResult.IsValid)
            {
                response.Success = false;
                response.Message = "RentCar Failed";
                response.Errors = validatorResult.Errors.Select(q => q.ErrorMessage).ToList();

                return response;
            }

            var car = await _carRepository.GetAsync(request.RentCarDto.Id);

            if (car == null)
            {
                response.Success = false;
                response.Message = "RentCar Failed";
                response.Errors = new List<string> { "El carro no existe" };

                return response;
            }

            if (car.Status == true || car.UserId!= null)
            {
                response.Success = false;
                response.Message = "RentCar Failed";
                response.Errors = new List<string> { "El carro se encuentra alquilado" };
                
                return response;
            }

            _mapper.Map(request.RentCarDto,car);
            car.RentCar();

            car = await _carRepository.UpdateAsync(car);
            var cardto = _mapper.Map<GetCarDto>(car);

            response.Message = "Carro alquilado con exito";

            return response;
        }
    }
}
