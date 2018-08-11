using System;

namespace SimpleGateway.Domain
{
    public class Merchant
    {
        public Guid MerchantId { get; set; }
        public Guid MerchantKey { get; set; }
        public int CNPJ { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool FraudAnalysis { get; set; }
        public Acquirer DefaultAcquirer { get; set; }
        public MerchantConfiguration Configuration { get; set; }
    }

    public class MerchantConfiguration
    {
        public Guid MerchantId { get; set; }
        public int Brand { get; set; }
        public int Acquirer { get; set; }
    }

    public enum Acquirer
    {
        CIELO = 0,
        STONE = 1
    }
}
