using Microsoft.AspNetCore.Mvc;
using SimpleGateway.Api.Factory;
using SimpleGateway.Api.Flters;
using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Api.Controllers
{
    [Route("/api/v1/payment/sales")]
    public class SalesController : ControllerBase
    {

        public readonly ISalesService SalesService;

        public SalesController(ISalesService salesService)
        {
            SalesService = salesService ?? throw new ArgumentNullException(nameof(salesService));
        }

        [HttpPost]
        [Route("")]
        [ValidateModelState]
        public IActionResult Post([FromHeader] Guid merchantId, [FromHeader]string merchantKey, [FromHeader] Guid ResquestId, [FromBody] SalesRequest request)
        {
            if (merchantId == default(Guid)) return CommandResultFactory.GetResult(new ContractResponse().BadRequest("MerchantId is Required"));
            if (string.IsNullOrEmpty(merchantKey)) return CommandResultFactory.GetResult(new ContractResponse().BadRequest("MerchantId is Required"));

            return CommandResultFactory.GetResult(SalesService.CreatePayment(merchantId, merchantKey, request));
        }
    }
}