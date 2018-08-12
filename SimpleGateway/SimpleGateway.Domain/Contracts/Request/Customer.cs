using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class Customer
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Identity { get; set; }
        public Address Address { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
    }
}
