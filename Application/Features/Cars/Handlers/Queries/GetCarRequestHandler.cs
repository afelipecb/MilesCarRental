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
    public class GetCarRequestHandler : IRequestHandler<GetCarRequest,GetCarDto>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetCarRequestHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<GetCarDto> Handle(GetCarRequest request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetCarDetailAsync(request.Id);
            return _mapper.Map<GetCarDto>(car);
        }
    }
}
