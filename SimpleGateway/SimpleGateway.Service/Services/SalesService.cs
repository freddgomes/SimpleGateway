using AutoMapper;
using SimpleGateway.Domain.ApiClient;
using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Enum;
using SimpleGateway.Domain.Services;
using System;
using System.Net;

namespace SimpleGateway.Service.Services
{
    public class SalesService : ISalesService
    {
        public readonly ICieloClient CieloClient;
        private readonly IMapper Mapper;

        public SalesService(ICieloClient cieloClient, IMapper mapper)
        {
            CieloClient = cieloClient ?? throw new ArgumentNullException(nameof(cieloClient));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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
                var response = CieloClient.CreateSale(merchantId, merchantKey, sales);

                if (response.Status == HttpStatusCode.Created)
                {
                    var transaction = Mapper.Map<SalesResponse>(response.Response);
                    response.Message = TransactionalStatusMessage(transaction.Payment.Status);
                }

                return response;
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

        private string TransactionalStatusMessage(int status)
        {
            return $"Acquirer transaction status: {(TransactionalStatus)status}";
        }
    }
}
