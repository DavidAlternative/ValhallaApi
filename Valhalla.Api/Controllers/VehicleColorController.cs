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
    public class VehicleColorController : ControllerBase
    {
        private readonly IVehicleColorService _service;

        public VehicleColorController(IVehicleColorService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetVehicleColors());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] GetVehicleColorByIdRequest request)
        {
            return Ok(_service.GetVehicleColor(request.Idcolor));
        }

        [HttpPost]

        public IActionResult Post(CreateVehicleColorRequest request)
        {
            _service.AddVehicleColor(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateVehicleColorRequest request)
        {
            _service.UpdateVehicleColor(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteVehicleColorRequest request)
        {
            _service.DeleteVehicleColor(request.Idcolor);
            return Ok();
        }
    }
}
