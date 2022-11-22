using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCE_commerce.DTO;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Controllers
{
    public class ChartController : Controller
    {
        private readonly IChartService _chartService;
        private readonly IChartRepository _chartRepository;

        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IStockProductService _stockProduct;


        public ChartController(IChartService chartService, IProductService productService, IOrderService orderService, IStockProductService stockProduct, IChartRepository chartRepository)
        {
            _chartService = chartService;
            _productService = productService; 
            _orderService=orderService;
            _stockProduct = stockProduct;
            _chartRepository = chartRepository;

        }


        public IActionResult Index()
        {
            var d = _stockProduct.GetStockProducts();
            return View(d.Data);
        }



        //public IActionResult CreateOrder ()
        //{

        //    return View();
        //}
        //public IActionResult CreateOrders()
        //{
        //    var email = HttpContext.Session.GetString("EmailAddress");
        //    var d = _chartService.CreateChart()
        //    ViewBag.Message = d.Message;
        //    if (d.Status == false)
        //    {
        //        NotFound("Customer not found");
        //    }
            
        //    return RedirectToAction("Index",new{id= d.Data.id});
        //}


        public IActionResult CreateOrder()
        {
            var Useremail = HttpContext.Session.GetString("EmailAddress");
            var f = _orderService.CreateOrder(Useremail);
            return View(f.Data);
        }


        public IActionResult CreateChart ()
        {

            var f = _stockProduct.GetStockProducts();
            ViewData["Products"] = new SelectList(f.Data, "ProductNo", "ProductName");
            return View();
            
        }
        [HttpPost]
        public IActionResult CreateChart (ChartRequestModel model)
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var d = _chartService.CreateChart( model,UserId.Value);
            ViewBag.Message = d.Message;
            if (d.Status == false)
            { 
                return View();
            }

            return RedirectToAction("GetAllChart");
        }



        public IActionResult GetAllChart ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var f = _chartRepository.GetChart(UserId.Value);
            var chart = _chartService.GetAllChart(f.Id);
            if (chart == null)
            {
                return NotFound($"Order does not exist");
            }
            else
            {
                return View(chart);
            }
        }


      
       


        public IActionResult BuyCharts ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var f = _chartRepository.GetChart(UserId.Value);
            var d = _chartService.BuyChart(f.Id);

            return View(d);
        }




        //public IActionResult UpdateChart ()
        //{
        //    var chart = _chartService.GetChart();
        //    if (chart == null)
        //    {
        //        return NotFound($"Item  not found");
        //    }
        //    else
        //    {
        //        return View(chart.Data);
        //    }
        //}
        //[HttpPost]
        public IActionResult UpdateChart(int id, ChartRequestModel model)
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
         
            var d = _chartService.UpdateChart(id, model,UserId.Value);
            ViewBag.Message = d.Message;
            if (d.Status == false)
            {
                return View();
            }

            return RedirectToAction("Index");
        }



        //public IActionResult DeleteChart(int id)
        //{

        //    var chart = _chartService.;
        //    if (chart == null)
        //    {
        //        return NotFound($"Item  not found");
        //    }
        //    else
        //    {
        //        return View(chart.Data);
        //    }
        //}
        //[HttpPost, ActionName("DeleteChart")]
        public IActionResult DeleteCharts(int id)
        {
            var d = _chartService.DeleteChart(id);
            ViewBag.Message = d.Message;
            if (d.Status == false)
            {
                return View("GetAllChart");
            }

            return RedirectToAction("GetAllChart");
        }
    }
}
