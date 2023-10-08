using RMAProject.Domain.Entities;
using RMAProject.Infrastructure.Repositories.Interfaces;

namespace RMAProject.Infrastructure.Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly RmaDbContext _context;
        public UserRepository(RmaDbContext context) : base(context)
        {
        }
    }
}
