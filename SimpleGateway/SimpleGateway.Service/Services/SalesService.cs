using SimpleGateway.Domain.ApiClient;
using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Service.Services
{
    public class SalesService : ISalesService
    {
        public readonly ICieloClient CieloClient;

        public SalesService(ICieloClient cieloClient)
        {
            CieloClient = cieloClient ?? throw new ArgumentNullException(nameof(cieloClient));
        }

        public ContractResponse CreatePayment(Guid merchantId, string merchantKey, SalesRequest sales)
        {
            try
            {
                if (!MerchantIsValid(merchantId))
                    return new ContractResponse().NotFound("Merchant Not Found");


                //receber dados da loja e da venda
                //verificar configurações da loja
                //usar adquirente default
                //
                return CieloClient.CreateSale(merchantId, merchantKey, sales);
            }
            catch (Exception ex)
            {
                return new ContractResponse().InternalServerError("An internal error has occurred. Contact API Manager.");
            }
        }

        private bool MerchantIsValid(Guid merchantId)
        {
            return true;
        }
    }
}
