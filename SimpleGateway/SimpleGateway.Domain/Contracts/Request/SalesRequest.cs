using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class SalesRequest
    {
        [Required]
        [StringLength(50)]
        public string MerchantOrderId { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Payment Payment { get; set; }
    }
}
