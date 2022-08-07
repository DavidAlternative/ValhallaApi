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
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetUsers());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] GetUserByIdRequest request)
        {
            return Ok(_service.GetUser(request.Iduser));
        }

        [HttpPost]

        public IActionResult Post(CreateUserRequest request)
        {
            _service.AddUser(request);
            return Ok();
        }

        [HttpPut]

        public IActionResult Put(UpdateUserRequest request)
        {
            _service.UpdateUser(request);
            return Ok();
        }
    }


}
