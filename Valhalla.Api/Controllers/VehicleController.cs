using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Valhalla.Application.Interfaces;
using Valhalla.Application.Requests;

namespace Valhalla.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetVehicles());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] GetVehicleByIdRequest request)
        {
            return Ok(_service.GetVehicle(request.Idvehicle));
        }

        [HttpPost]

        public IActionResult Post(CreateVehicleRequest request)
        {
            _service.AddVehicle(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateVehicleRequest request)
        {
            _service.UpdateVehicle(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteVehicleRequest request)
        {
            _service.DeleteVehicle(request.Idvehicle);
            return Ok();
        }
    }
}
