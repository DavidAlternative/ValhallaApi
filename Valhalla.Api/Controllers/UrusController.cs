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
    public class UrusController : ControllerBase
    {
        private readonly IUrusService _service;

        public UrusController(IUrusService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetUrus());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] GetUrusByIdRequest request)
        {
            return Ok(_service.GetUrus(request.Idurus));
        }

        [HttpPost]

        public IActionResult Post(CreateUrusRequest request)
        {
            _service.AddUrus(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateUrusRequest request)
        {
            _service.UpdateUrus(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteUrusRequest request)
        {
            _service.DeleteUrus(request.Idurus);
            return Ok();
        }
    }
}
