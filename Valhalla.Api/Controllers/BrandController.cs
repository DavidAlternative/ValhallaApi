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
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandController(IBrandService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetBrands());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] GetBrandByIdRequest request)
        {
            return Ok(_service.GetBrand(request.Idbrand));
        }

        [HttpPost]

        public IActionResult Post(CreateBrandRequest request)
        {
            _service.AddBrand(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateBrandRequest request)
        {
            _service.UpdateBrand(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteBrandRequest request)
        {
            _service.DeleteBrand(request.Idbrand);
            return Ok();
        }
    }
}
