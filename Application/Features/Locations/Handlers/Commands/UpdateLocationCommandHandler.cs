using Application.Contracts.Persistance;
using Application.DTOs.Location.Validators;
using Application.DTOs.Location;
using Application.Features.Locations.Requests.Commands;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Locations.Handlers.Commands
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, LocationDto>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public UpdateLocationCommandHandler(ILocationRepository locationRepository,IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<LocationDto> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var validator = new LocationDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.LocationDto);

            if (!validatorResult.IsValid)
            {
                throw new Exception();
            }

            var location = await _locationRepository.GetAsync(request.LocationDto.Id);

            if (location == null)
            {
                throw new Exception();
            }

            _mapper.Map(request.LocationDto, location);

            location = await _locationRepository.UpdateAsync(location);
            var locationdto = _mapper.Map<LocationDto>(location);

            return locationdto;
        }
    }
}
