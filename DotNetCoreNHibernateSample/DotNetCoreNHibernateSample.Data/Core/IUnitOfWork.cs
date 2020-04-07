using System;
using DotNetCoreNHibernateSample.Data.Core.Repositories;

namespace DotNetCoreNHibernateSample.Data.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IPersonRepository PersonRepository { get; }
        void SaveChanges();
    }
}
