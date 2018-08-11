namespace SimpleGateway.Domain.ValueObjects
{
    public class CommandResult
    {
        public ReturnType ReturnType { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }

        public CommandResult Created(object data = null)
        {
            ReturnType = ReturnType.Created;
            Data = data;
            return this;
        }

        public CommandResult Success(object data = null)
        {
            ReturnType = ReturnType.Success;
            Data = data;
            return this;
        }

        public CommandResult Fail(string message)
        {
            ReturnType = ReturnType.Fail;
            Message = message;
            return this;
        }

        public CommandResult InvalidContract(string message)
        {
            ReturnType = ReturnType.InvalidContract;
            Message = message;
            return this;
        }

        public CommandResult NotFound(string message)
        {
            ReturnType = ReturnType.NotFound;
            Message = message;
            return this;
        }

        public CommandResult ObjectAlreadyRemoved(string message)
        {
            ReturnType = ReturnType.ObjectAlreadyRemoved;
            Message = message;
            return this;
        }

        public CommandResult Conflict(string message)
        {
            ReturnType = ReturnType.Conflict;
            Message = message;
            return this;
        }
    }

    public enum ReturnType
    {
        Unknown,
        Created,
        Success,
        Fail,
        InvalidContract,
        Conflict,
        NotFound,
        ObjectAlreadyRemoved
    }
}
