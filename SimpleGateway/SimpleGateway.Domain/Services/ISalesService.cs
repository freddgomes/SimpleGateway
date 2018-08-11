using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.ValueObjects;
using System;

namespace SimpleGateway.Domain.Services
{
    public interface ISalesService
    {
        CommandResult CreatePayment(Guid merchantId, Guid merchantKey, SalesRequest sales);
    }
}
