using Serilog;
using SimpleGateway.Domain.Services;
using System;

namespace SimpleGateway.Service.Services
{
    public class LogService : ILogService
    {
        public void Info(string message)
        {
            Log.Information(message);
        }

        public void Error(Exception ex, string message)
        {
            Log.Error(ex, message);
        }
    }
}
