using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using Chart = MVCE_commerce.Entities.Chart;


namespace MVCE_commerce.Interface.Service
{
    public interface IChartService
    {
        ResponseModel        CreateChart (ChartRequestModel model,int customeeId);
        ResponseModel      UpdateChart (int id,ChartRequestModel model,int customerId);
        ResponseModel       DeleteChart (int id);
        public ResponseModels GetChart (int customerId);
        public Response BuyChart(int OrderId);
        ResponseModels GetAllChart (int orderId);
        
    }
}
