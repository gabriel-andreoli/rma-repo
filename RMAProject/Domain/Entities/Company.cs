using RMAProject.Domain.Entities.GenericsEntities;

namespace RMAProject.Domain.Entities
{
    public class Company : BaseClass
    {
        public string Name { get; set; }
        public string CPNJ { get; set; }
        public Address Address { get; set; }
        public Company() { }
    }
}
