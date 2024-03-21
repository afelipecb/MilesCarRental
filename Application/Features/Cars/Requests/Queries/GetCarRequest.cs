using Application.DTOs.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Requests.Queries
{
    public class GetCarRequest : IRequest<GetCarDto>
    {
        public int Id { get; set; }
    }
}
