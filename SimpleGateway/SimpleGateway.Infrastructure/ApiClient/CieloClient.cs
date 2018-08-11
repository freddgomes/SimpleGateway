using RestSharp;
using SimpleGateway.Domain.Configuration;
using SimpleGateway.Domain.Contracts.Request;
using System;

namespace SimpleGateway.Infrastructure.ApiClient
{
    public class CieloClient
    {
        private IAppSettings AppSettings;

        public CieloClient(IAppSettings appSettings)
        {
            AppSettings = appSettings ?? throw new System.ArgumentNullException(nameof(appSettings));
        }

        public void CreateSale(Guid merchantId, Guid merchantKey, SalesRequest sales)
        {
            var client = new RestClient(GetUrl());
            var request = new RestRequest(Method.POST);
        }

        private string GetUrl()
        {
            var url = AppSettings.GetConfig("AppSettings:Endpoints:CieloApi");
            return url;
        }
    }
}
