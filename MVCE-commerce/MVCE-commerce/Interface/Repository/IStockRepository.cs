using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
   public interface IStockRepository
    {
        Stock CreateStock(Stock stock);
        Stock UpdateStock (Stock stock);
        bool DeleteStock (Stock stock);
        Stock GetStock (string StockNo);
        IList<Stock> GetStocks();


    }
}
