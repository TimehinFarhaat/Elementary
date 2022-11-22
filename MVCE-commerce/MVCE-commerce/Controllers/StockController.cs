using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCE_commerce.DTO;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Controllers
{
    public class StockController:Controller
    {
        private readonly IStockService _stockService;
        private readonly IAdminService _adminService;

        public StockController(IStockService stock, IAdminService adminService)
        {
            _stockService = stock;
            adminService = _adminService;
        }

        public IActionResult Index ()
        {
            var t = _stockService.GetStocks();
            return View(t.Data);
        }


        public IActionResult AddStocks()
        {
            var id = HttpContext.Session.GetString("Email");
            var ids = HttpContext.Session.GetString("Address");
            var dw = _stockService.CreateStock(id);
            ViewBag.Message = dw.Message;

            return RedirectToAction("Detail",new{NO=dw.Data.StockNo});
        }



       
        public IActionResult UpdateStock (string NO)
        {
            var id = HttpContext.Session.GetString("Email");
            var ids = HttpContext.Session.GetString("Address");
            var d = _stockService.UpdateStock(NO,id);
            return RedirectToAction("Index");
        }




        public IActionResult Details (string no)
        {
            var stock = _stockService.GetsStock(no);
            if (stock.Status==false)
            {
                return NotFound(stock.Message);
            }
            return View(stock.Data);
            
        }


        public IActionResult Detail(string no)
        {
            var stock = _stockService.GetStock(no);
            if (stock.Status == false)
            {
                return NotFound($"Customer with  id {no} does not exist");
            }
            else
            {
                return View(stock.Data);
            }
        }




        public IActionResult DeleteStock (string id)
        {
            var stock = _stockService.GetStock(id);
            if (stock == null)
            {
                return View(stock.Message);
            }
            else
            {
                return View(stock.Data);
            }
        }
        [HttpPost, ActionName("DeleteStock")]
        public IActionResult DeleteConfirmed (string id)
        {
            var d = _stockService.DeleteStock(id);
            if (d != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction($"Not Found");
            }
        }
    }

}

