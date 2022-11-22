using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineShopping.Repositories
{
   public interface IBaseRepository<T>
   {
       public T Create(T obj);
       public T Get (Expression<Func<T,bool>> expression);
       public List<T> GetMany (Expression<Func<T, bool>> expression);
        public T Update (T obj);
       public bool Delete (int id);


    }
   
}
