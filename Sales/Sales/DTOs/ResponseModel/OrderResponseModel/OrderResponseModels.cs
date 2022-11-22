using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.OrderDTO;


namespace Sales.DTOs.ResponseModel.OrderResponseModel
{
    public class OrderResponseModels:BaseResponse
    {
        public IList<OrderDtO> Data { get; set; }
    }
}
