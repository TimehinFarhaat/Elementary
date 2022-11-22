using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace RepositoryPatternAPI.Interfaces.Repository
{
    public interface IBaseRepository<T>
    {
        public void   Add(T entity);
        public void Delete (T entity);
        public IQueryable Query();
        public IQueryable<T> Query (Expression<Func<T, bool>> expression);
        public void Update (T entity);
        public IList<T> Get(IList<int> ids);
        public IList<T> Get();
        public IList<T> GetByExpression (Expression<Func<T, bool>> expression);
        public T Get(Expression<Func<T,bool>> expression);
        public bool Exist (Expression<Func<T, bool>> expression);
    }
}
