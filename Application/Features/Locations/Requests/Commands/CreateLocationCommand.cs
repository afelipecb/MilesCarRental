using Application.DTOs.Location;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Locations.Requests.Commands
{
    public class CreateLocationCommand : IRequest<LocationDto>
    {
        public CreateLocationDto LocationDto { get; set; }
    }
}
