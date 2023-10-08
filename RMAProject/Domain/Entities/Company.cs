using RMAProject.Domain.Entities.GenericsEntities;

namespace RMAProject.Domain.Entities
{
    public class Company : BaseClass
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPNJ { get; set; }
        public Address Address { get; set; }
        public Guid AddressId { get; set; }
        public IEnumerable<User> Users { get; set; }
        public Company() { }
    }
}
