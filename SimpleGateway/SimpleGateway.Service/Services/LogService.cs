using Serilog;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Service.Services
{
    public class LogService : ILogService
    {
        public void Info(string message, object obj)
        {
            Log.Information(message, obj);
        }

        public void Error(Exception ex, string message)
        {
            Log.Error(ex, message);
        }
    }
}
