using Microsoft.Extensions.Configuration;

namespace SimpleGateway.Domain.Configuration
{
    public class AppSettings : IAppSettings
    {
        private IConfiguration Configuration;

        public AppSettings(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetConfig(string key)
        {
            return Configuration[key];
        }
    }
}
