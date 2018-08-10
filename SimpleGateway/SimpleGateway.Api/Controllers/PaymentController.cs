using Microsoft.AspNetCore.Mvc;

namespace SimpleGateway.Api.Controllers
{
    [Route("/api/payment/transaction")]
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
