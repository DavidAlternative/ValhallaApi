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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetOrders());
        }

        [HttpGet("{id}")]

        public IActionResult Get([FromRoute] GetOrderByIdRequest request)
        {
            return Ok(_service.GetOrder(request.Idorder));
        }

        [HttpPost]

        public IActionResult Post(CreateOrderRequest request)
        {
            _service.AddOrder(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteOrderRequest request)
        {
            _service.DeleteOrder(request.Idorder);
            return Ok();
        }
    }
}

