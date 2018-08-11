using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Services;
using SimpleGateway.Domain.ValueObjects;
using System;

namespace SimpleGateway.Service.Services
{
    public class SalesService : ISalesService
    {
        public CommandResult CreatePayment(Guid merchantId, Guid merchantKey, SalesRequest sales)
        {
            if (!MerchantIsValid(merchantId))
                return new CommandResult().NotFound("Merchant Not Found");


            //receber dados da loja e da venda
            //verificar configurações da loja
            //usar adquirente default
            //


            return new CommandResult().Success(sales);

        }

        private bool MerchantIsValid(Guid merchantId)
        {
            return true;
        }
    }
}
