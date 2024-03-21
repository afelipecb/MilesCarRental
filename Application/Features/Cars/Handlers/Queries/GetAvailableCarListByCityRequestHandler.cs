using Application.Contracts.Persistance;
using Application.DTOs.Car;
using Application.Features.Cars.Requests.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Cars.Handlers.Queries
{
    public class GetAvailableCarListByCityRequestHandler : IRequestHandler<GetAvailableCarListByCityRequest, List<GetAvailableCarDto>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetAvailableCarListByCityRequestHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAvailableCarDto>> Handle(GetAvailableCarListByCityRequest request, CancellationToken cancellationToken)
        {
            var availableCars = await _carRepository.GetAllInCityAsync(request.city);
            return _mapper.Map<List<GetAvailableCarDto>>(availableCars);
        }
    }
}
