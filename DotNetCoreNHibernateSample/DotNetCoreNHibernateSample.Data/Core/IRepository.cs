using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DotNetCoreNHibernateSample.Data.Core
{
    public interface IRepository<TEntity, ID> where TEntity : class
    {
        TEntity Get(ID id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
