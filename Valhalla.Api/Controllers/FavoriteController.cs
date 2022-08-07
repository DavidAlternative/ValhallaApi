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
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteService _service;

        public FavoriteController(IFavoriteService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetFavorites());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] string id)
        {
            return Ok(_service.GetFavorite(id));
        }

        [HttpPost]

        public IActionResult Post(CreateFavoriteRequest request)
        {
            _service.AddFavorite(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] string id)
        {
            _service.DeleteFavorite(id);
            return Ok();
        }

    }
}
