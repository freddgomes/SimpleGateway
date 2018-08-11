using Microsoft.AspNetCore.Mvc;
using SimpleGateway.Api.Flters;
using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using System;
using System.Net;

namespace SimpleGateway.Api.Controllers
{
    [Route("/api/v1/payment/sales")]
    public class SalesController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        [ValidateModelState]
        public IActionResult Post([FromHeader] Guid MerchantId, [FromHeader]Guid MerchantKey, [FromBody] SalesRequest request)
        {
            //TODO: receber merchant id e merchant key por header
            //Validar merchant
            //criar pagamento
            //retornar status e link de consulta
            return Created("", new ContractResponse
            {
                Message = "Teste",
                Status = (int)HttpStatusCode.Created,
                Response = request
            }
            );
        }
    }
}
