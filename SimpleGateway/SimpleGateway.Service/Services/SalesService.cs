﻿using AutoMapper;
using Newtonsoft.Json;
using SimpleGateway.Domain.ApiClient;
using SimpleGateway.Domain.Contracts.Request;
using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Entities;
using SimpleGateway.Domain.Enum;
using SimpleGateway.Domain.Repository;
using SimpleGateway.Domain.Services;
using System;
using System.Net;

namespace SimpleGateway.Service.Services
{
    public class SalesService : ISalesService
    {
        public readonly ICieloClient CieloClient;
        public readonly ITransactionRepository TransactionRepository;
        private readonly IMapper Mapper;
        public readonly ILogService LogService;

        public SalesService(ICieloClient cieloClient, IMapper mapper, ITransactionRepository transactionRepository, ILogService logService)
        {
            CieloClient = cieloClient ?? throw new ArgumentNullException(nameof(cieloClient));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            TransactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
            LogService = logService ?? throw new ArgumentNullException(nameof(logService));
        }

        public ContractResponse CreateSale(Guid merchantId, string merchantKey, SalesRequest sales)
        {
            try
            {
                var response = CieloClient.CreateSale(merchantId, merchantKey, sales);

                if (response.Status == HttpStatusCode.Created)
                {
                    SalesResponse saleResponse = (SalesResponse)response.Response;
                    response.Message = TransactionalStatusMessage(saleResponse.Payment.Status);

                    var transaction = Mapper.Map<SalesResponse, Transaction>(saleResponse);
                    transaction.MerchantId = merchantId;

                    TransactionRepository.SaveTransaction(transaction);
                    saleResponse.GatewayTransactionId = transaction.Id;

                    LogService.Info($"Sale successfully. Sales information: {JsonConvert.SerializeObject(transaction)}");
                }

                return response;
            }
            catch (Exception ex)
            {
                LogService.Error(ex, "An error occurred while performing a transaction.");
                return new ContractResponse().InternalServerError("An internal error has occurred. Contact API Manager.");
            }
        }

        private string TransactionalStatusMessage(int status)
        {
            return $"Acquirer transaction status: {(TransactionalStatus)status}";
        }
    }
}
