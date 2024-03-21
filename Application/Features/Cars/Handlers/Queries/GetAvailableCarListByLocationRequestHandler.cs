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
    public class GetAvailableCarListByLocationRequestHandler : IRequestHandler<GetAvailableCarListByLocationRequest, List<GetAvailableCarDto>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetAvailableCarListByLocationRequestHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAvailableCarDto>> Handle(GetAvailableCarListByLocationRequest request, CancellationToken cancellationToken)
        {
            var availableCars = await _carRepository.GetAllInLocationAsync(request.locationid);
            return _mapper.Map<List<GetAvailableCarDto>>(availableCars);
        }
    }
}
