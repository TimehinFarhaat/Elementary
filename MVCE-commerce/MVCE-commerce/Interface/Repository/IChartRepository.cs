using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
    public interface IChartRepository
    {
        Chart    CreateChart (Chart responseModel);
        Chart    UpdateChart (Chart responseModel);
        Chart FindChart (int id);
        bool     DeleteChart (Chart responseModel);
        public Order GetChart(int customerId);
        IList<Chart> GetAllChart (int orderId);
        
    }
}
