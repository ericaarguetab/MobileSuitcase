namespace MobileSuitcase.BackEnd.Persistance
{
    using MobileSuitcase.BackEnd.Core;
    using MobileSuitcase.BackEnd.Core.Repositories;
    using MobileSuitcase.BackEnd.Persistance.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
            Users = new UserRepository();
            Workers = new WorkerRepository();
        }

        public IUserRepository Users { get; private set; }
        public IWorkerRepository Workers { get; private set; }

        public void Dispose()
        {
         
        }
    }
}
