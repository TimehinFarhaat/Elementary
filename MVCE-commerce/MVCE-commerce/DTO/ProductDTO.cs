using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }
        public IList<CategoryProduct> CategoryItems { get; set; } = new List<CategoryProduct>();
    }

    public class ProductRequestModel
    {
        public string Name { get; set; }
        public IList<int> CategoryItems { get; set; } = new List<int>();
    }


  

    //public class ProductDTOs
    //{

    //    public string ItemId { get; set; }
    //    public string Name { get; set; }
    //}

    public class ProductsResponseModel : BaseResponse
    {
        public IList<ProductDTO> Data { get; set; }
    }

    public class ProductResponseModel:BaseResponse
    {
        public ProductDTO Data { get; set; }
    }
}

