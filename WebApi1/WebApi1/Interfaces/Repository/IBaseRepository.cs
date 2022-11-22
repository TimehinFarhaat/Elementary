using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi1.Entity;


namespace WebApi1.Interfaces.Repository
{
    public interface IBaseRepository<T> where T:BaseEntity,new()
    {
        public T  Add (T    entity);
        public void  Delete (T entity);
        public IQueryable<T>  Query ();
        public IQueryable<T> Query (Expression<Func<T, bool>> expression);
        public T  Update (T entity);
        public IList<T>  Get (IList<int>ids);
        public IList<T>  GetAll();
        public IList<T>  GetAll (Expression<Func<T, bool>> expression);
        public T   Get (Expression<Func<T, bool>>expression);
        public bool   Exists (Expression<Func<T, bool>> expression);
    }
}
