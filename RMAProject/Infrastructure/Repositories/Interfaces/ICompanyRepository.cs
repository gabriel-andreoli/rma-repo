using RMAProject.Domain.Entities;

namespace RMAProject.Infrastructure.Repositories.Interfaces
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        Company GetById(Guid companyId);
    }
}
