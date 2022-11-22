using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace Sales.DTOs.CategoryDTO.RequestModel
{
    public class ItemRequestModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        public IList<int> CategoryIds { get; set; }=new List<int>();
        public IFormFile Image { get; set; }
    }
}
