using Application.Contracts.Persistance;
using Application.DTOs.Car;
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
    public class ReturnCarCommandHandler : IRequestHandler<ReturnCarCommand, BaseCommandResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly ILocationRepository _locationRepository;

        public ReturnCarCommandHandler(ICarRepository carRepository, IMapper mapper,IUserRepository userRepository, ILocationRepository locationRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _locationRepository = locationRepository;
        }

        public async Task<BaseCommandResponse> Handle(ReturnCarCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new ReturnCarDtoValidator(_userRepository, _locationRepository);
            var validatorResult = await validator.ValidateAsync(request.ReturnCarDto);

            if (!validatorResult.IsValid)
            {
                response.Success = false;
                response.Message = "RentCar Failed";
                response.Errors = validatorResult.Errors.Select(q => q.ErrorMessage).ToList();

                return response;
            }

            var car = await _carRepository.GetAsync(request.ReturnCarDto.Id);
            
            _mapper.Map(request.ReturnCarDto,car);
            car.ReturnCar();

            car = await _carRepository.UpdateAsync(car);
            var cardto = _mapper.Map<GetCarDto>(car);

            response.Message = "Carro devuelto con exito";
            return response;
        }
    }
}
