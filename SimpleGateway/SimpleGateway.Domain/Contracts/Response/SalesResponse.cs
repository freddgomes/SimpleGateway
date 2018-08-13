namespace SimpleGateway.Domain.Contracts.Response
{
    public class SalesResponse
    {
        public string MerchantOrderId { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
    }
}
