using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CategoryDTO;
using Sales.Entities;


namespace Sales.DTOs.ResponseModel.CategoryResponseModel
{
    public class CategoryResponseModel:BaseResponse
    {
        public CategoryDtO Data { get; set; }
    }
}
