﻿namespace SimpleGateway.Domain.Contracts.Response
{

    public class SalesResponse
    {
        public string MerchantOrderId { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
    }

    public class Payment
    {
        public int ServiceTaxAmount { get; set; }
        public int Installments { get; set; }
        public int Interest { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public bool Recurrent { get; set; }
        public Creditcard CreditCard { get; set; }
        public string Tid { get; set; }
        public string ProofOfSale { get; set; }
        public string AuthorizationCode { get; set; }
        public string SoftDescriptor { get; set; }
        public string Provider { get; set; }
        public int Amount { get; set; }
        public string ReceivedDate { get; set; }
        public int Status { get; set; }
        public bool IsSplitted { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnCode { get; set; }
        public string PaymentId { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public Link[] Links { get; set; }
    }

    public class Creditcard
    {
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public string ExpirationDate { get; set; }
        public bool SaveCard { get; set; }
        public string Brand { get; set; }
    }

    public class Link
    {
        public string Method { get; set; }
        public string Rel { get; set; }
        public string Href { get; set; }
    }
}
