using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.OrderDTO;


namespace Sales.DTOs.ResponseModel.OrderResponseModel
{
    public class OrderResponseModel:BaseResponse
    {
        public OrderDtO Data { get; set; }
    }
}
