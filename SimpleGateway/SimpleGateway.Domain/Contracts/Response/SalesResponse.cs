using System;

namespace SimpleGateway.Domain.Contracts.Response
{
    public class SalesResponse
    {
        public Guid GatewayTransactionId { get; set; }
        public string MerchantOrderId { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
    }
}
