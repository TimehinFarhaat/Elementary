using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Repository;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Implementations.Service
{
    public class CategoryService:ICategory
    {
        private readonly ICategoryRepository _categoryRepository;



        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }




        public CategoryResponseModel CreateCategory(CategorysRequestModel categoryRequest)
        {
            var category = new Category()
            {
                Name = categoryRequest.Name,
                Description = categoryRequest.Description
            };

            var d = _categoryRepository.CreateCategory(category);
            if (d == null)
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
                Data = new CategoryDTO()
                {
                    Name = category.Name,
                    Description = category.Description,
                    CategoryId = category.Id
                }
            };
        }





        public CategoryResponseModel UpdateCategory(int id, CategorysRequestModel categoryRequest)
        {
            var d = _categoryRepository.GetCategory(id);
            if (d == null)
            {
                return new CategoryResponseModel()
                {
                    Message = "Not Found",
                    Status = false
                };
            }

            d.Name = categoryRequest.Name;
            d.Description = categoryRequest.Description;
            var s = _categoryRepository.UpdateCategory(d);
            return new CategoryResponseModel
            {

                Data = new CategoryDTO
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
            var d = _categoryRepository.GetAllCategory();
            return new CategoriesResponseModel()
            {
                Data = d.Select(v => new CategoryDTO()
                         {
                             Name = v.Name,
                             Description = v.Description,
                             CategoryId = v.Id,
                             CategoryProducts = v.CategoryProducts

                         })
                        .ToList()
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
                    Data = new CategoryDTO()
                    {
                        CategoryId = f.Id,
                        Description = f.Description,
                        Name = f.Name,
                        CategoryProducts = f.CategoryProducts
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


     


        public BaseResponse DeleteCategory(int id)
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
