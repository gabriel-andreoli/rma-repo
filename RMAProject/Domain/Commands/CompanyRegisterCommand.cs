using RMAProject.Domain.Entities;

namespace RMAProject.Domain.Commands
{
    public class CompanyRegisterCommand
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPNJ { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Neighbour { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
        public string? NumberAddress { get; set; }
        public string? Complement { get; set; }
    }
}
