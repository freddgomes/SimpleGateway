namespace SimpleGateway.Domain.Contracts.Request
{
    public class Creditcard
    {
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        public Brand Brand { get; set; }
    }
}
