using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Inetrface.Repository
{
   public interface ICategoryRepository
    {
        Category     CreateCategory (Category category);
        Category   UpdateCategory (Category category);
        bool        DeleteCategory (Category category);
        IList<Category>   GetAllCategory ();
        Category GetCategory(int id);

        IList<Category> GetsCategory (IList<int> Ids);
    }
}
