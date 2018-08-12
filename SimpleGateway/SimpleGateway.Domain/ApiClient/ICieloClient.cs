using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using System;

namespace SimpleGateway.Domain.ApiClient
{
    public interface ICieloClient
    {
        ContractResponse CreateSale(Guid merchantId, string merchantKey, SalesRequest sales);
    }
}