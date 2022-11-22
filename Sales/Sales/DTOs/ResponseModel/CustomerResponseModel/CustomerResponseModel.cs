using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CustomerDTO;


namespace Sales.DTOs.ResponseModel.CategoryResponseModel
{
    public class CustomerResponseModel:BaseResponse
    {
        public CustomerDtO Data  { get; set; }
    }
}
