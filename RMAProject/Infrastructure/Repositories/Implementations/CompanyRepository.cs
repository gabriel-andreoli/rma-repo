using RMAProject.Domain.Entities;
using RMAProject.Infrastructure.Repositories.Interfaces;

namespace RMAProject.Infrastructure.Repositories.Implementations
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly RmaDbContext _context;
        public CompanyRepository(RmaDbContext context) : base(context) { }
        public Company GetById(Guid companyId) 
        {
            return _context.Company.FirstOrDefault(x => x.Id == companyId && !x.Deleted);

        }
    }
}
