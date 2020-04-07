using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DotNetCoreNHibernateSample.Data.Core;
using NHibernate;

namespace DotNetCoreNHibernateSample.Data.Persistence.Repositories
{
    public class Repository<TEntity, ID> : IRepository<TEntity, ID> where TEntity : class
                                                                    where ID : struct
    {
        protected readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }

        public TEntity Get(ID id)
        {
            return _session.Get<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _session.Query<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _session.Query<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _session.Query<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            _session.Save(entity);
        }

        public void Remove(TEntity entity)
        {
            _session.Delete(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _session.SaveOrUpdate(entity);
            }
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _session.Delete(entity);
            }
        }
    }
}
