using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.DTO
{
    public class StockDTO
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string AdminName { get; set; }
        public string ProductName { get; set; }
        public string StockNo { get; set; }
        public IList<StockProduct> StockProducts { get; set; }=new List<StockProduct>();
    }

    public class StockProductDTO
    {
        public int Id { get; set; }
        public string StockId { get; set; }
        public decimal UnitPrice { get; set; }
        public string StockProductNo { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal CostPrice { get; set; }
        public string ProductNo { get; set; }
    }



    public class StockProductRequestModel
    {
        public string StockId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public string ProductNo { get; set; }
    }



    public class StockProductResponseModel:BaseResponse
    {
        public IList<StockProductDTO> Data { get; set; }
    }



    public class StockProductResponseModels : BaseResponse
    {
        public StockProductDTO Data { get; set; }
    }



    public class StockRequestModel
    {
        public string Password { get; set; }
        public string EmailAddress { get; set; }
    }




    public class StocksResponseModel : BaseResponse
    {
        public IList<StockDTO> Data { get; set; }
    }



    public class StockResponseModel:BaseResponse
    {
        public StockDTO Data { get; set; }
    }
}
