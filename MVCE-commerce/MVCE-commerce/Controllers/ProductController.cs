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
    public class ProductController:Controller
    {
        private readonly IProductService _productService;
        private readonly ICategory _categoryService;


        public ProductController(IProductService productService,ICategory categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index ()
        {
            var f = _productService.GetProducts();
            return View(f.Data);
        }


        public IActionResult CreateItem()
        {
            var f = _categoryService.GetCategories();
            ViewData["Categories"] = new SelectList(f.Data, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateItem(ProductRequestModel requestModel)
        {
           var d= _productService.AddProducts(requestModel);
           if (d.Status == true)
           {
               return RedirectToAction("Index");
           }

           return View($"Unsuccessful");
        }



        public IActionResult UpdateItem (string productNo)
        {
            var g = _productService.GetProduct(productNo);
            if (g == null)
            {
                return NotFound($"Item with {productNo} does not exist");
            }
            else
            {
                var f = _categoryService.GetCategories();
                ViewData["Categories"] = new SelectList(f.Data, "CategoryId", "Name");
                return View();
            }

        }
        [HttpPost]
        public IActionResult UpdateItem (string No, ProductRequestModel requestModel)
        {
            _productService.UpdateProducts(No, requestModel);
            return RedirectToAction("Index");
        }




        public IActionResult Delete (string id)
        {
            var g = _productService.GetProduct(id);
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
            _productService.DeleteProducts(id);
            return RedirectToAction("Index");
        }




        public IActionResult GetDetails (string id)
        {
            var f = _productService.GetProduct(id);
            if (f == null)
            {
                {
                    return NotFound($"Item with id {id} does not exist");
                }
            }
            return View(f.Data);
        }
    }
}
