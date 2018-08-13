namespace SimpleGateway.Domain.Contracts.Response
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
        public Address Address { get; set; }
        public Deliveryaddress DeliveryAddress { get; set; }
    }

}
