using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApi1.Context;
using WebApi1.Entity;
using WebApi1.Interfaces.Repository;


namespace WebApi1.Implementation.Repositorys
{
    public  abstract class BaseRepository<T>:IBaseRepository<T> where T:BaseEntity,new()
    {

        protected ApplicationContext _context;




        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }


        
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            
        }



        public IQueryable<T> Query()
        {
            return _context.Set<T>().AsQueryable();
        }



        public IQueryable<T> Query(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList().AsQueryable();
        }



        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }





        public IList<T> Get(IList<int> ids)
        {
            var entities = _context.Set<T>().Where(r => ids.Contains(r.Id)).ToList();
            return entities;
        }





        public IList<T> GetAll()
        {
            var entities = _context.Set<T>().ToList();
            return entities;
        }




        public IList<T> GetAll(Expression<Func<T, bool>> expression)
        {
            var entities = _context.Set<T>().Where(expression).ToList();
            return entities;
        }






        public T Get(Expression<Func<T, bool>> expression)
        {
            var entity=_context.Set<T>().SingleOrDefault(expression);
            return entity;
        }




        public bool Exists(Expression<Func<T, bool>> expression)
        {
            var t = _context.Set<T>().Any(expression);
            return t;
        }
    }
}
