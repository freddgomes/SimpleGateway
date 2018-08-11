using SimpleGateway.Domain.ValueObjects;
using System.Net;
using System.Web.Http;

namespace SimpleGateway.Api.Factory
{
    public class CommandResultFactory
    {
        public static NegotiatedContentResult<dynamic> GetResult(CommandResult commandResult = null)
        {
            if (commandResult == null)
                commandResult = new CommandResult
                {
                    Message = ""
                };

            switch (commandResult.ReturnType)
            {
                case ReturnType.NotFound:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.NotFound, commandResult.Message);
                case ReturnType.Conflict:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.Conflict, commandResult.Message);
                case ReturnType.Success:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.OK, commandResult.Data);
                case ReturnType.Created:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.Created, commandResult.Data);
                default:
                    return new NegotiatedContentResult<dynamic>(HttpStatusCode.BadRequest, commandResult.Message);
            }
        }
    }
}
