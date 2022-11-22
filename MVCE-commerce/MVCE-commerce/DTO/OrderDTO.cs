using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.DTO
{
    public class OrderDTO
    {
        public int id { get; set; }
    }

    public class OrderResponse:BaseResponse
    {
        public OrderDTO Data { get; set; }
    }

    public class ChartDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
     
    }


    public class ChartDTOs
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }

        public string Name { get; set; }

    }



    public class Response : BaseResponse
    {
        public IList<ChartDTOs> Data { get; set; }
        public decimal Amount { get; set; }
    }

    public class ResponseModels:BaseResponse
    {
        public IList<ChartDTO> Data { get; set; }
    }

    public class ChartRequestModel
    {
        
        public int Quantity { get; set; }
        public string ProductNo { get; set; }
    }


    public class ChartRequestModels
    {
        public string ProductId { get; set; }
        public int OrderId { get; set; }
    }


    public class ResponseModel:BaseResponse
    {
        public ChartDTO Data { get; set; }
    }
}
