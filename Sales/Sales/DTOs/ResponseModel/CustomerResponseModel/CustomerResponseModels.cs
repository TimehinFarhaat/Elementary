using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CustomerDTO;


namespace Sales.DTOs.ResponseModel.CustomerResponseModel
{
    public class CustomerResponseModels:BaseResponse
    {
        public IList<CustomerDtO> Data { get; set; }
    }
}
