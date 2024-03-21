using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Requests.Commands
{
    public class DeleteCarCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; }
    }
}
