using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CategoryDTO;
using Sales.Entities;


namespace Sales.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Category CreateCategory (Category     category);
        Category  UpdateCategory (Category category);
        bool DeleteCategory (Category category);
        IList<Category> GetAllCategory();
        IList<CategoryDtO> GetsAllCategory();
        Category GetCategory(int id);
      //  CategoryDtO GetsCategory(int id);
        IList<Category> GetsCategory (IList<int>Ids);
    }
}
