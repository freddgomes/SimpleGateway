using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Creditcard
    {
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string Holder { get; set; }
        [Required]
        public string ExpirationDate { get; set; }
        [Required]
        public string SecurityCode { get; set; }
        [Required]
        public Brand Brand { get; set; }
    }
}
