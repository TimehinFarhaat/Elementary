using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Entities;


namespace Sales.DTOs.CategoryDTO.RequestModel
{
    public class CategoryRequestModel
    {
      
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CategoryItem> CategoryItems { get; set; }=new List<CategoryItem>();
    }
}
