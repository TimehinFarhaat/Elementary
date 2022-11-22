using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.DTO
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public IList<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
    }

    public class CategorysRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class CategoryRequestModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public IList<CategoryProduct> CategoryItems { get; set; } = new List<CategoryProduct>();
    }
    


    public class CategoriesResponseModel:BaseResponse
    {
        public IList<CategoryDTO> Data { get; set; }
    }



    public class CategoryResponseModel:BaseResponse
    {
        public CategoryDTO Data { get; set; }
    }
}
