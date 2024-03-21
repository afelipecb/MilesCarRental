using Application.DTOs;
using Application.DTOs.Car;
using Application.Features.Cars.Requests.Commands;
using Application.Features.Cars.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MilesCarRental.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: CarController
        [HttpGet("GetCarById")]
        [SwaggerOperation(Summary = "Obtiene la informacion de un carro por su ID")]
        public async Task<ActionResult<GetCarDto>> Get(int id)
        {
            var car = await _mediator.Send(new GetCarRequest() { Id = id });

            return car;
        }

        [SwaggerOperation(Summary = "Obtiene el listado de carros disponibles para alquilar en la ciudad especificada")]
        [HttpGet("GetAvailableCarListByCity")]
        public async Task<ActionResult<List<GetAvailableCarDto>>> GetListWithLocation(string city)
        {
            var availablesCars = await _mediator.Send(new GetAvailableCarListByCityRequest() { city = city });

            return availablesCars;
        }

        [SwaggerOperation(Summary = "Obtiene el listado de carros disponibles para alquilar segun el Id de la Locacion especificada")]
        [HttpGet("GetAvailableCarListByLocationId")]
        public async Task<ActionResult<List<GetAvailableCarDto>>> GetListWithLocation(int locationId)
        {
            var availablesCars = await _mediator.Send(new GetAvailableCarListByLocationRequest() { locationid = locationId });

            return availablesCars;
        }

        [SwaggerOperation(Summary = "Crea un nuevo carro y lo asocia a una locacion")]
        [HttpPost("CreateCar")]
        public async Task<ActionResult<string>> Post(CarDto carInfo)
        {
            var carId = await _mediator.Send(new AddCarCommand() { CarDto = carInfo });

            return Ok(carId);
        }

        [SwaggerOperation(Summary = "Pone en estado de alquiler un carro, se debe ingresar el id del carro, el id del usuario que alquila el carro y el id de la locacion donde sera entregado el carro")]
        [HttpPost("RentCar")]
        public async Task<ActionResult<BaseCommandResponse>> Post(RentCarDto carInfo)
        {
            var car = await _mediator.Send(new RentCarCommand() { RentCarDto = carInfo });

            return car;
        }

        [SwaggerOperation(Summary = "Pone el carro en estado disponible de nuevo para ser alquilado")]
        [HttpPost("ReturnCar")]
        public async Task<ActionResult<BaseCommandResponse>> Post(ReturnCarDto carInfo)
        {
            var car = await _mediator.Send(new ReturnCarCommand() { ReturnCarDto = carInfo });

            return car;
        }

        [SwaggerOperation(Summary = "Modifica la informacion de un carro")]
        [HttpPut("UpdateCarInfo")]
        public async Task<ActionResult<BaseCommandResponse>> Put(UpdateCarDto carInfo)
        {
            var car = await _mediator.Send(new UpdateCarCommand() { updateCarDto = carInfo });

            return car;
        }

        [SwaggerOperation(Summary = "Elimina un carro por su Id")]
        [HttpDelete("DeleteCarById")]
        public async Task<ActionResult<bool>> Delete(int carId)
        {
            var success = await _mediator.Send(new DeleteCarCommand() { Id = carId });

            return Ok();
        }
    }
}
