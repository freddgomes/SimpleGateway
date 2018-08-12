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
            Message = message;
            return this;
        }

        public ContractResponse BadRequest(string message)
        {
            Status = HttpStatusCode.BadRequest;
            Message = message;
            return this;
        }

        public ContractResponse NotFound(string message)
        {
            Status = HttpStatusCode.NotFound;
            Message = message;
            return this;
        }

        public ContractResponse InternalServerError(string message)
        {
            Status = HttpStatusCode.InternalServerError;
            Message = message;
            return this;
        }
    }
}
