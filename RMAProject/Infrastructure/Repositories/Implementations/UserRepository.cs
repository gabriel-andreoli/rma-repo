using RMAProject.Domain.Entities;

namespace RMAProject.Infrastructure.Repositories.Implementations
{
    public class UserRepository : GenericRepository<User>
    {
        private readonly RmaDbContext _context;
        public UserRepository(RmaDbContext context) : base(context)
        {
        }
    }
}
