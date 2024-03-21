using Application.DTOs.Location;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Locations.Requests.Queries
{
    public class GetLocationRequest : IRequest<LocationDto>
    {
        public int Id { get; set; }
    }
}
