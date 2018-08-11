using System;

namespace SimpleGateway.Domain.Entities
{
    public class MerchantConfiguration
    {
        public Guid MerchantId { get; set; }
        public int Brand { get; set; }
        public int Acquirer { get; set; }
    }
}
