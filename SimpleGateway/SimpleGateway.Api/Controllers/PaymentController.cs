using Microsoft.AspNetCore.Mvc;

namespace SimpleGateway.Api.Controllers
{
    [Route("/api/v1/payment/sale")]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] object value)
        {
            return Created("", value);
        }
    }
}
