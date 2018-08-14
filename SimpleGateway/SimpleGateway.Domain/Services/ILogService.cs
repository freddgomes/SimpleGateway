using System;

namespace SimpleGateway.Domain.Services
{
    public interface ILogService
    {
        void Error(Exception ex, string message);
        void Info(string message, object obj);
    }
}