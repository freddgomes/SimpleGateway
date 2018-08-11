using Microsoft.AspNetCore.Mvc;
using SimpleGateway.Api.Flters;
using SimpleGateway.Domain.Contracts.Request;

namespace SimpleGateway.Api.Controllers
{
    [Route("/api/v1/payment/sales")]
    public class SalesController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        [ValidateModelState]
        public IActionResult Post([FromBody] SalesRequest request)
        {
            //TODO: receber merchant id e merchant key por header e validar
            return Created("", "");
        }
    }
}
