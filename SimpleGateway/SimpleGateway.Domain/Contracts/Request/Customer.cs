using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Customer
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(14)]
        public string Identity { get; set; }
        public Address Address { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
    }
}
