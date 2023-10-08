using RMAProject.Domain.Commands;
using RMAProject.Domain.Entities;
using RMAProject.Domain.SeedWork;
using RMAProject.Presentation.Services.Interfaces;

namespace RMAProject.Presentation.Services.Implementations
{
    public class CompanyService : ServiceBase, ICompanyService
    {
        public CompanyService(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public async Task RegisterCompany(CompanyRegisterCommand command) 
        {
            var newAddress = new Address(command.Country, command.State, command.City, command.Neighbour, command.Street, command.NumberAddress, command.PostalCode, command.Complement);
            var newCompany = new Company()
            {
                Address = newAddress,
                Name = command.Name,
                Email = command.Email,
                CPNJ = command.CPNJ
            };
            Commit();
        }
    }
}
