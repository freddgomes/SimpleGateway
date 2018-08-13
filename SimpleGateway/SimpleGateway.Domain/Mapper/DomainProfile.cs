using AutoMapper;
using SimpleGateway.Domain.Contracts.Response;
using SimpleGateway.Domain.Entities;

namespace SimpleGateway.Domain.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<SalesResponse, Transaction>().AfterMap((src, dest) =>
            {
                dest.CustomerName = src.Customer.Name;
                dest.ServiceTaxAmount = src.Payment.ServiceTaxAmount;
                dest.Installments = src.Payment.Installments;
                dest.Capture = src.Payment.Capture;
                dest.Authenticate = src.Payment.Authenticate;
                dest.Recurrent = src.Payment.Recurrent;
                dest.Tid = src.Payment.Tid;
                dest.ProofOfSale = src.Payment.ProofOfSale;
                dest.AuthorizationCode = src.Payment.AuthorizationCode;
                dest.Provider = src.Payment.Provider;
                dest.Amount = src.Payment.Amount;
                dest.ReceivedDate = src.Payment.ReceivedDate;
                dest.CapturedAmount = src.Payment.CapturedAmount;
                dest.CapturedDate = src.Payment.CapturedDate;
                dest.Status = src.Payment.Status;
                dest.IsSplitted = src.Payment.IsSplitted;
                dest.ReturnCode = src.Payment.ReturnCode;
                dest.ReturnMessage = src.Payment.ReturnMessage;
                dest.PaymentId = src.Payment.PaymentId;
                dest.Type = src.Payment.Type;
                dest.Currency = src.Payment.Currency;
                dest.Country = src.Payment.Country;
                dest.CardNumber = src.Payment.CreditCard.CardNumber;
                dest.Brand = src.Payment.CreditCard.Brand;
            });
        }
    }
}
