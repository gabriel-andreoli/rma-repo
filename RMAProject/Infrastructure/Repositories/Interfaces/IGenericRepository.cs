namespace RMAProject.Infrastructure.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAllAsEnumerable();
        IQueryable<T> GetAllAsQueryable(Guid CompanyId);
        IEnumerable<T> GetAllAsNoTracking(Guid CompanyId);
        T GetById(Guid id);
        T GetByIdAsNoTracking(Guid id);
    }
}
