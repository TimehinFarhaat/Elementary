using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Entities;


namespace Sales.DTOs.CategoryDTO
{
    public class CategoryDtO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

    }
}
