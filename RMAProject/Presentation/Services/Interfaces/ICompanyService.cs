using RMAProject.Domain.Commands;

namespace RMAProject.Presentation.Services.Interfaces
{
    public interface ICompanyService
    {
        Task RegisterCompany(CompanyRegisterCommand command);
    }
}
