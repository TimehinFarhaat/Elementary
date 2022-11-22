using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CategoryDTO.RequestModel;
using Sales.DTOs.ResponseModel.CategoryResponseModel;
using Sales.Entities;


namespace Sales.Interfaces.Services
{
    public   interface ICategoryService
    {
        public CategoryResponseModel CreateCategory(CategoryRequestModel categoryRequest);
        public CategoryResponseModel UpdateCategory (int id,CategoryRequestModel categoryRequest);

        public CategoriesResponseModel GetCategories();

       public CategoryResponseModel GetCategory(int id);
       public Category GetCateagory (int id);
        public CategoryResponseModel DeleteCategory (int id);
    }
}
