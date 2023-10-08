using RMAProject.Domain.Entities.GenericsEntities;

namespace RMAProject.Domain.Entities
{
    public class Address : BaseClass
    {
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Neighbour { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
        public string? NumberAddress { get; set; }
        public string? Complement { get; set; }
        public Address() => Register();
        public Address(string country, string state, string city, string neighbour, string street, string postalCode, string numberAddress, string complement) 
        {
            Country = country;
            State = state;
            City = city;
            Neighbour = neighbour;
            Street = street;
            PostalCode = postalCode;
            NumberAddress = numberAddress;
            Complement = complement;
            Register();
        }
    }
}
