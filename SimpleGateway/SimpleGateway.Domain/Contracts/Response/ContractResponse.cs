using System.Net;

namespace SimpleGateway.Domain.Contracts.Response
{
    public class ContractResponse
    {
        public HttpStatusCode Status { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }

        public ContractResponse Success(object response = null)
        {
            Status = HttpStatusCode.OK;
            Response = response;
            return this;
        }

        public ContractResponse Created(object response = null)
        {
            Status = HttpStatusCode.Created;
            Response = response;
            return this;
        }

        public ContractResponse Unauthorized(string message)
        {
            Status = HttpStatusCode.Unauthorized;
            Message = Message;
            return this;
        }

        public ContractResponse BadRequest(string message)
        {
            Status = HttpStatusCode.BadRequest;
            Message = Message;
            return this;
        }

        public ContractResponse NotFound(string message)
        {
            Status = HttpStatusCode.NotFound;
            Message = Message;
            return this;
        }

        public ContractResponse InternalServerError(string message)
        {
            Status = HttpStatusCode.InternalServerError;
            Message = Message;
            return this;
        }
    }
}
