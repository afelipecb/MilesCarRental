using Application.Contracts.Persistance;
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
    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommand, bool>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public DeleteLocationCommandHandler(ILocationRepository locationRepository, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            if (!await _locationRepository.ExistAsync(request.Id))
            {
                throw new Exception();
            }

            await _locationRepository.DeleteAsync(await _locationRepository.GetAsync(request.Id));

            return true;
        }
    }
}
