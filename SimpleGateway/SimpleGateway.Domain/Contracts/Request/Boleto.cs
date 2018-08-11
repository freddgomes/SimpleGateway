namespace SimpleGateway.Domain.Contracts.Request
{
    public class Boleto
    {
        public int Amount { get; set; }
        public string Provider { get; set; }
        public string Address { get; set; }
        public string BoletoNumber { get; set; }
        public string Assignor { get; set; }
        public string Demonstrative { get; set; }
        public string ExpirationDate { get; set; }
        public string Identification { get; set; }
        public string Instructions { get; set; }
    }
}
