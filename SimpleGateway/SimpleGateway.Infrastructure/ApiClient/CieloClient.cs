using RestSharp;
using SimpleGateway.Domain.ApiClient;
using SimpleGateway.Domain.Configuration;
using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using System;

namespace SimpleGateway.Infrastructure.ApiClient
{
    public class CieloClient : ICieloClient
    {
        private IAppSettings AppSettings;
        private IRestClient RestClient;
        private IRestRequest RestRequest;

        public CieloClient(IAppSettings appSettings)
        {
            AppSettings = appSettings ?? throw new ArgumentNullException(nameof(appSettings));
            RestClient = new RestClient();
            RestRequest = new RestRequest();
        }

        public ContractResponse CreateSale(Guid merchantId, string merchantKey, SalesRequest sales)
        {
            RestClient.BaseUrl = new Uri(GetUrl());
            RestRequest.Method = Method.POST;
            RestRequest.Resource = "sales";
            RestRequest.AddHeader("Content-Type", "application/json");
            RestRequest.AddHeader("MerchantId", $"{merchantId.ToString()}");
            RestRequest.AddHeader("MerchantKey", $"{merchantKey}");

            RestRequest.AddJsonBody(sales);

            var response = RestClient.Execute<SalesResponse>(RestRequest);
            return new ContractResponse
            {
                Message = response.Content,
                Status = response.StatusCode,
                Response = response.Data
            };
        }

        private string GetUrl()
        {
            var url = AppSettings.GetConfig("AppSettings:Endpoints:CieloApi");
            if (string.IsNullOrWhiteSpace(url))
                throw new InvalidOperationException("Configuration [AppSettings:Endpoints:CieloApi] is invalid");

            if (!url.EndsWith("/"))
                url = url + "/";

            return url;
        }
    }
}
