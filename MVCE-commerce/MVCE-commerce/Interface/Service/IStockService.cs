using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;


namespace MVCE_commerce.Inetrface.Service
{
   public interface IStockService
    {
        StockResponseModel    CreateStock (string email);
        StockResponseModel   UpdateStock (string stockNo, string email);
        StockResponseModel DeleteStock(string StockNo);
        StockResponseModel GetsStock(string stockNo);
        StockResponseModel      GetStock (string   stockNo);
        StocksResponseModel GetStocks ();
    }
}
