using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineShopping.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>where T:class
    { 
        protected ApplicatinContext context { get; set; }


        public T Create(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
            return obj;
        }


        public bool Delete(int id)
        {
            var s = context.Set<T>().Find(id);
            context.Remove(s);
            if (s==null)
            {
                return false;
            }

            context.SaveChanges();
            return true;
        }



        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().FirstOrDefault(expression);
        }




        public List<T> GetMany(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression).ToList();
        }




        public T Update(T obj)
        {
            context.Set<T>().Update(obj);
            context.SaveChanges();
            return obj;
        }
    }
}
