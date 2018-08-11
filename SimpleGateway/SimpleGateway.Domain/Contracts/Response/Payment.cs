using SimpleGateway.Domain.Contracts.Request;

namespace SimpleGateway.Domain.Contracts.Response
{
    public class Payment
    {
        public int ServiceTaxAmount { get; set; }
        public int Installments { get; set; }
        public string Interest { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public Creditcard CreditCard { get; set; }
        public DebitCard DebitCard { get; set; }
        public string AuthenticationUrl { get; set; }
        public string Tid { get; set; }
        public string SoftDescriptor { get; set; }
        public string PaymentId { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public object[] ExtraDataCollection { get; set; }
        public int Status { get; set; }
        public string ReturnCode { get; set; }
        public Link[] Links { get; set; }
    }
}
