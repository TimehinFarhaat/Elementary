using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CategoryDTO;
using Sales.DTOs.CategoryDTO.RequestModel;
using Sales.DTOs.ResponseModel.CategoryResponseModel;
using Sales.Entities;
using Sales.Implementations.Repositories;
using Sales.Interfaces.Repositories;
using Sales.Interfaces.Services;


namespace Sales.Implementations.Sevices
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;





        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }




        public CategoryResponseModel CreateCategory(CategoryRequestModel categoryRequest)
        {
            var category=new Category()
            {
                Name = categoryRequest.Name,
                Description=categoryRequest.Description
            };

            var d = _categoryRepository.CreateCategory(category);
            if (d==null)
            {
                return new CategoryResponseModel()
                {
                    Message = "Unsuccessful",
                    Status = false,
                };
            }

            return new CategoryResponseModel()
            {
                Message = $"{d.Name} successfully created",
                Status = true,
                Data = new CategoryDtO()
                {
                    Name = category.Name,
                    Description = category.Description,
                    CategoryId = category.Id
                }
            };
        }





        public CategoryResponseModel UpdateCategory(int id,CategoryRequestModel categoryRequest)
        {
            var d = _categoryRepository.GetCategory(id);
            if (d==null)
            {
                return new CategoryResponseModel()
                {
                    Message = "Not Found",
                    Status = false
                };
            }
            d.Name = categoryRequest.Name;
            d.Description = categoryRequest.Description;
           var s= _categoryRepository.UpdateCategory(d);
            return new CategoryResponseModel
            {
                
                Data = new CategoryDtO
                {
                    Name = s.Name,
                    Description = s.Description,
                    

                },
                Status = true,
                Message = "Updated Successfully",
            };
            
        }






        public CategoriesResponseModel GetCategories()
        {
            var d = _categoryRepository.GetsAllCategory();
            return new CategoriesResponseModel()
            {
                Data = d,
            };
        }

        




        public CategoryResponseModel GetCategory(int id)
        {
            var f = _categoryRepository.GetCategory(id);
            if (f != null)
            {
                return new CategoryResponseModel()
                {
                    Message = "Found",
                    Status = true,
                    Data = new CategoryDtO()
                    {
                        CategoryId = f.Id,
                        Description = f.Description,
                        Name = f.Name
                    }
                };
            }
            else
            {
                return new CategoryResponseModel()
                {
                    Message = "Not Found",
                    Status = false
                };
            }

        }


        public Category GetCateagory(int id)
        {
            var g = _categoryRepository.GetCategory(id);
            return g;
        }


        public CategoryResponseModel DeleteCategory (int id)
        {
            var f = _categoryRepository.GetCategory(id);
            var g = _categoryRepository.DeleteCategory(f);
            if (g == false)
            {
                return new CategoryResponseModel()
                {
                    Message = $" not Deleted ",
                    Status = false
                };

            }
            else
            {
                return new CategoryResponseModel()
                {

                    Message = $" Deleted ",
                    Status = true
                };
            }
        }


























    }
}
