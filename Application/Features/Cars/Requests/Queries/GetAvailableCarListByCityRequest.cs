using Application.DTOs.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Requests.Queries
{
    public class GetAvailableCarListByCityRequest : IRequest<List<GetAvailableCarDto>>
    {
        public string city { get; set; }
    }
}
