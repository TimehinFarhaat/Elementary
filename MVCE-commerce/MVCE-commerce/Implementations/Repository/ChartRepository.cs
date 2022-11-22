using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class ChartRepository:IChartRepository
    {
        private readonly ApplicationContext _context;


        public ChartRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Chart CreateChart(Chart responseModel)
        {
            _context.Charts.Add(responseModel);
            _context.SaveChanges();
            return responseModel;
        }



        public Chart UpdateChart(Chart responseModel)
        {
            _context.Charts.Update(responseModel);
            _context.SaveChanges();
            return responseModel;
        }


        public Chart FindChart(int id)
        {
            var g = _context.Charts.Find(id);
            return g;
        }


        public bool DeleteChart(Chart responseModel)
        {
            _context.Charts.Remove(responseModel);
            _context.SaveChanges();
            return true;
        }



        public Order GetChart(int customerId)
        {

            var d = _context.Orders.Where(o => o.CustomerId == customerId).OrderBy(o=>o.Id).LastOrDefault();
            return d;
        }




        public IList<Chart> GetAllChart (int orderId)
        {

            var d = _context.Charts.Where(o => o.OrderId==orderId).ToList();
            return d;
        }
    }
}
