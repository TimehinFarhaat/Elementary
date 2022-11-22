using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;


namespace MVCE_commerce.Interface.Service
{
    public interface IStockProductService
    {
        StockProductResponseModels       AddStockProduct (StockProductRequestModel    product);
        StockProductResponseModels        UpdateStockProduct (string num,StockProductRequestModel product);
        bool      DeleteStockProduct (String product);
        StockProductResponseModels        GetStockProduct (string   id);
        StockProductResponseModel GetStockProducts ();
    }
}
