using System;

namespace SimpleGateway.Domain.Entities
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
}
