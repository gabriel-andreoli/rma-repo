using Microsoft.EntityFrameworkCore;
using RMAProject.Domain.Entities.GenericsEntities;
using RMAProject.Infrastructure.Repositories.Interfaces;

namespace RMAProject.Infrastructure.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private readonly RmaDbContext _context;
        public GenericRepository(RmaDbContext context) 
        {
            _context = context;
        }

        public IEnumerable<T> GetAllAsEnumerable()
        {
            return _context.Set<T>().Where(x => !x.Deleted).AsEnumerable();
        }

        public IEnumerable<T> GetAllAsNoTracking(Guid CompanyId)
        {
            return _context.Set<T>().Where(x => !x.Deleted).AsNoTracking().AsEnumerable();
        }

        public IQueryable<T> GetAllAsQueryable(Guid CompanyId)
        {
            return _context.Set<T>().Where(x => !x.Deleted).AsQueryable();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id && !x.Deleted);
        }

        public T GetByIdAsNoTracking(Guid id)
        {
            return _context.Set<T>().Where(x => x.Id == id && !x.Deleted).AsNoTracking().FirstOrDefault();
        }
    }
}
