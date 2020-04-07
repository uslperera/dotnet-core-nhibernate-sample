using System;
using System.Threading.Tasks;
using DotNetCoreNHibernateSample.Data.Core;
using DotNetCoreNHibernateSample.Data.Core.Repositories;
using DotNetCoreNHibernateSample.Data.Persistence.Repositories;
using NHibernate;

namespace DotNetCoreNHibernateSample.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public IPersonRepository PersonRepository { get; private set; }

        public UnitOfWork(ISession session)
        {
            _session = session;
            PersonRepository = new PersonRepository(_session);
        }

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            _session.Dispose();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
