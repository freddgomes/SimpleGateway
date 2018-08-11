using SimpleGateway.Domain.Validator;
using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Payment
    {
        [Required]
        public PaymentType Type { get; set; }
        [Required]
        public int Amount { get; set; }
        public int Installments { get; set; }
        [RequiredIf("Type", PaymentType.CreditCard)]
        public Creditcard CreditCard { get; set; }
    }

    public enum PaymentType
    {
        CreditCard,
        DebitCard,
        Boleto

    }

}
