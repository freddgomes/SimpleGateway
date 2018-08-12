using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Payment
    {
        [Required]
        [StringLength(100)]
        public string Type { get; set; }
        [Required]
        public int Amount { get; set; }
        public int Installments { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [StringLength(3)]
        public string Country { get; set; }
        public bool Capture { get; set; }
        [Required]
        public Creditcard CreditCard { get; set; }
    }
}
