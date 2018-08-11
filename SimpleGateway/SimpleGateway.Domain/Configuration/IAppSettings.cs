namespace SimpleGateway.Domain.Configuration
{
    public interface IAppSettings
    {
        string GetConfig(string key);
    }
}