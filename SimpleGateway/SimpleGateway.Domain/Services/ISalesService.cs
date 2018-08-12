using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using System;

namespace SimpleGateway.Domain.Services
{
    public interface ISalesService
    {
        ContractResponse CreateSale(Guid merchantId, string merchantKey, SalesRequest sales);
    }
}
