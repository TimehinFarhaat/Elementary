using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RepositoryPatternAPI.Context;
using RepositoryPatternAPI.Entities;
using RepositoryPatternAPI.Interfaces.Repository;


namespace RepositoryPatternAPI.Implementation
{
    public abstract class BaseRepository<T>:IBaseRepository<T> where T:BaseEntity,new()
    {
        protected ApplicationContext _context;


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }


      
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }


        public IQueryable Query()
        {
            return _context.Set<T>().AsQueryable(); 
        }



        public IQueryable<T> Query(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList().AsQueryable();
        }







     
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }






        public IList<T> Get(IList<int> ids)
        {
            var entity = _context.Set<T>().Where(j => ids.Contains(j.Id));
            return entity.ToList();
        }



        public IList<T> Get()
        {
            var entity = _context.Set<T>().ToList();
            return entity;
        }



        public IList<T> GetByExpression(Expression<Func<T, bool>> expression)
        {
            var entity = _context.Set<T>().Where(expression);
            return entity.ToList();
        }


        public T Get(Expression<Func<T, bool>> expression)
        {
            var d = _context.Set<T>().SingleOrDefault(expression);
            return d;
        }


        public bool Exist(Expression<Func<T, bool>> expression)
        {
            var d = _context.Set<T>().Any(expression);
            return d;
        }
    }
}
