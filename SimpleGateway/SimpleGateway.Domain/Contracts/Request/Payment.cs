using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Payment
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public int Amount { get; set; }
        public int Installments { get; set; }
        [Required]
        public Creditcard CreditCard { get; set; }
    }

    public enum PaymentType
    {
        CreditCard,
        DebitCard,
        Boleto

    }

}
