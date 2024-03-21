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
    public class RentCarCommand : IRequest<BaseCommandResponse>
    {
        public RentCarDto RentCarDto { get; set; }
    }
}
