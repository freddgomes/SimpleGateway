using System.ComponentModel.DataAnnotations;

namespace SimpleGateway.Domain.Contracts.Request
{
    public class DeliveryAddress
    {
        [StringLength(255)]
        public string Street { get; set; }
        [StringLength(15)]
        public string Number { get; set; }
        [StringLength(50)]
        public string Complement { get; set; }
        [StringLength(9)]
        public string ZipCode { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(35)]
        public string Country { get; set; }
    }

}
