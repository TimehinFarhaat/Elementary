using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Service
{
    public interface ICategory
    {
        public CategoryResponseModel CreateCategory (CategorysRequestModel categoryRequest);
        public CategoryResponseModel UpdateCategory (int    id, CategorysRequestModel categoryRequest);

        public CategoriesResponseModel GetCategories ();

        public CategoryResponseModel GetCategory (int id);
        public BaseResponse DeleteCategory (int id);
    }
}
