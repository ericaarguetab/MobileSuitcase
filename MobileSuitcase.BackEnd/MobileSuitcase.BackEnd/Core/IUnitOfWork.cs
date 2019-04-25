namespace MobileSuitcase.BackEnd.Core
{
    using System;
    using MobileSuitcase.BackEnd.Core.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IWorkerRepository Workers { get; }
    }
}
