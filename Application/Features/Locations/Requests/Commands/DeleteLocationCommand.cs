using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Locations.Requests.Commands
{
    public class DeleteLocationCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
