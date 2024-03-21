using Application.DTOs.Location;
using Application.Features.Locations.Requests.Commands;
using Application.Features.Locations.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MilesLocationRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: LocationController
        [HttpGet("GetLocationById")]
        public async Task<ActionResult<LocationDto>> Get(int id)
        {
            var location = await _mediator.Send(new GetLocationRequest() { Id = id });

            return location;
        }

        [HttpPost("CreateLocation")]
        public async Task<ActionResult<LocationDto>> Post(CreateLocationDto locationInfo)
        {
            var locationId = await _mediator.Send(new CreateLocationCommand() { LocationDto = locationInfo });

            return Ok(locationId);
        }

        [HttpPut("UpdateLocationInfo")]
        public async Task<ActionResult<LocationDto>> Put(LocationDto locationInfo)
        {
            var location = await _mediator.Send(new UpdateLocationCommand() { LocationDto = locationInfo });

            return location;
        }

        [HttpDelete("DeleteLocationById")]
        public async Task<ActionResult<bool>> Delete(int locationId)
        {
            var success = await _mediator.Send(new DeleteLocationCommand() { Id = locationId });

            return Ok();
        }
    }
}
