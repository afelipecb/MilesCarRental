using Application.Contracts.Persistance;
using Application.DTOs.Location;
using Application.Features.Locations.Requests.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Locations.Handlers.Queries
{
    public class GetLocationRequestHandler : IRequestHandler<GetLocationRequest,LocationDto>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public GetLocationRequestHandler(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<LocationDto> Handle(GetLocationRequest request, CancellationToken cancellationToken)
        {
            var car = await _locationRepository.GetAsync(request.Id);
            return _mapper.Map<LocationDto>(car);
        }
    }
}
