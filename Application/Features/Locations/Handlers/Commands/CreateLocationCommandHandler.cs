using Application.Contracts.Persistance;
using Application.DTOs.Location;
using Application.Features.Locations.Requests.Commands;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Locations.Handlers.Commands
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, LocationDto>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public CreateLocationCommandHandler(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<LocationDto> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var location = _mapper.Map<Location>(request.LocationDto);
            location = await _locationRepository.AddAsync(location);
            var locationDto= _mapper.Map<LocationDto>(location);
            return locationDto ;
        }
    }
}
