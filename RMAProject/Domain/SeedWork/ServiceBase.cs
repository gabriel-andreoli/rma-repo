using RMAProject.Infrastructure;

namespace RMAProject.Domain.SeedWork
{
    public abstract class ServiceBase
    {
        private readonly IUnitOfWork _unityOfWork;
        public ServiceBase(IUnitOfWork unityOfWork) 
        {
            _unityOfWork = unityOfWork;
        }

        protected void Commit() 
        {
            _unityOfWork.Commit();
        }
    }
}
