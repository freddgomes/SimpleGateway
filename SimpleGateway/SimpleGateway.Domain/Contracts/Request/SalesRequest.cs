using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class SalesRequest
    {
        [Required]
        public string MerchantOrderId { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Payment Payment { get; set; }
    }
}
