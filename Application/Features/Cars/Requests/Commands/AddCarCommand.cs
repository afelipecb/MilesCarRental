using Application.DTOs.Car;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Requests.Commands
{
    public class AddCarCommand : IRequest<BaseCommandResponse>
    {
        public CarDto CarDto { get; set; }
    }
}
