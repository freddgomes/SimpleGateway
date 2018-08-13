using System;

namespace SimpleGateway.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid MerchantId { get; set; }
        public string MerchantOrderId { get; set; }
        public string CustomerName { get; set; }
        public int ServiceTaxAmount { get; set; }
        public int Installments { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public bool Recurrent { get; set; }
        public string Tid { get; set; }
        public string ProofOfSale { get; set; }
        public string AuthorizationCode { get; set; }
        public string Provider { get; set; }
        public int Amount { get; set; }
        public string ReceivedDate { get; set; }
        public int CapturedAmount { get; set; }
        public string CapturedDate { get; set; }
        public int Status { get; set; }
        public bool IsSplitted { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnCode { get; set; }
        public string PaymentId { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public string CardNumber { get; set; }
        public string Brand { get; set; }
    }
}
