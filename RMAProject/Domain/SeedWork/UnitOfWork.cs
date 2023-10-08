using RMAProject.Infrastructure;

namespace RMAProject.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RmaDbContext _context;
        public UnitOfWork(RmaDbContext context) 
        {
            _context = context;
        }

        public void Commit() 
        {
            _context.SaveChanges();
        }
    }
}
