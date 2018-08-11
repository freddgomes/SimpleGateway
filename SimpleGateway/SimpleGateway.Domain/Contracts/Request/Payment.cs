using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Payment
    {
        [Required]
        public PaymentType Type { get; set; }
        [Required]
        public int Amount { get; set; }
        public Creditcard CreditCard { get; set; }
        public DebitCard DebitCard { get; set; }
        public Boleto Boleto { get; set; }
    }

    public enum PaymentType
    {
        CreditCard,
        DebitCard,
        Boleto

    }

}
