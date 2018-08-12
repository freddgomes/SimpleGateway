namespace SimpleGateway.Domain.Contracts.Response
{
    public class Creditcard
    {
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public string ExpirationDate { get; set; }
        public bool SaveCard { get; set; }
        public string Brand { get; set; }
    }
}
