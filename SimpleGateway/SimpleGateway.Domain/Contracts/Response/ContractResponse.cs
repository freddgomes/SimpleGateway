namespace SimpleGateway.Domain.Contracts.Response
{
    public class ContractResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }
    }
}
