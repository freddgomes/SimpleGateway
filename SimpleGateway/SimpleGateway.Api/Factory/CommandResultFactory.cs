using SimpleGateway.Domain.Contracts.Response;
using System.Net;
using System.Web.Http;

namespace SimpleGateway.Api.Factory
{
    public class CommandResultFactory
    {

        public static NegotiatedContentResult<dynamic> GetResult(ContractResponse response = null)
        {
            if (response == null)
                response = new ContractResponse
                {
                    Message = "There was a problem performing the operation",
                    Status = HttpStatusCode.BadRequest
                };

            switch (response.Status)
            {
                case HttpStatusCode.NotFound:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.NotFound, response);
                case HttpStatusCode.Unauthorized:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.NotFound, response);
                case HttpStatusCode.BadRequest:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.BadRequest, response);
                case HttpStatusCode.Conflict:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.Conflict, response);
                case HttpStatusCode.OK:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.OK, response);
                case HttpStatusCode.Created:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.Created, response);
                case HttpStatusCode.InternalServerError:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.InternalServerError, response);
                default:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.BadRequest, response);
            }
        }
    }
}
