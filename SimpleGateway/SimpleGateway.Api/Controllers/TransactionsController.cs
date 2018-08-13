using Microsoft.AspNetCore.Mvc;
using SimpleGateway.Api.Factory;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Api.Controllers
{
    [Route("/api/v1/transactions")]
    public class TransactionsController : ControllerBase
    {
        public readonly ITransactionsService TransactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            TransactionsService = transactionsService;
        }

        [HttpGet]
        [Route("{merchantId}")]
        public IActionResult GetTransactions(Guid merchantId)
        {
            return CommandResultFactory.GetResult(TransactionsService.GetTransactionsByMerchant(merchantId));
        }
    }
}
