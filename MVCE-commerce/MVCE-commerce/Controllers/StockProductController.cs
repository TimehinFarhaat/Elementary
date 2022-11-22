using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCE_commerce.DTO;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Controllers
{
    public class StockProductController:Controller
    {
        private readonly IStockProductService _stockProductService;
        private readonly IProductService _productService;


        public StockProductController(IStockProductService stockProductService,IProductService  productService)
        {
            _stockProductService = stockProductService;
            _productService = productService;
        }
        public IActionResult Index ()
        {
            var f = _stockProductService.GetStockProducts();
            return View(f.Data);
        }


        public IActionResult CreateStockProduct ()
        {
            var f =  _productService.GetProducts();
            ViewData["Products"] = new SelectList(f.Data, "ItemId", "Name");
            return View();
        }


        [HttpPost]
        public IActionResult CreateStockProduct(StockProductRequestModel requestModel)
        {
            var d = _stockProductService.AddStockProduct(requestModel);
            return RedirectToAction("CreateStockProduct");

        }


        public IActionResult UpdateStockProduct (string productNo)
        {
            var g = _stockProductService.GetStockProduct(productNo);
            if (g == null)
            {
                return NotFound($"Item with {productNo} does not exist");
            }
            else
            {
                var f = _productService.GetProducts();
                ViewData["Products"] = new SelectList(f.Data, "ItemId", "Name");
                return View();
            }

        }
        [HttpPost]
        public IActionResult UpdateStockProduct(string No, StockProductRequestModel requestModel)
        {
            _stockProductService.UpdateStockProduct(No, requestModel);
            return RedirectToAction("Index");
        }




        public IActionResult Delete (string id)
        {
            var g = _stockProductService.GetStockProduct(id);
            if (g == null)
            {
                return NotFound($"Item with  id {id} does not exist");
            }
            else
            {
                return View(g.Data);
            }

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteItem (string id)
        {
            _stockProductService.DeleteStockProduct(id);
            return RedirectToAction("Index");
        }




        public IActionResult GetDetails (string id)
        {
            var f = _stockProductService.GetStockProduct(id);
            if (f == null)
            {
                {
                    return NotFound($"Item with id {id} does not exist");
                }
            }
            return View(f);
        }
    }
}
