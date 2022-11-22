using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Sales.DTOs.CategoryDTO.RequestModel;
using Sales.Interfaces.Services;


namespace Sales.Controllers
{
    public class ItemController:Controller
    {
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryService;


        public ItemController(IItemService itemService,ICategoryService categoryService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
          var f=  _itemService.GetAllItems();
            return View(f.Data);
        }


        public IActionResult CreateItem()
        {
            var f = _categoryService.GetCategories();
              ViewData["Categories"]=new SelectList(f.Data, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateItem(ItemRequestModel requestModel)
        {
            _itemService.CreateItem(requestModel);
            return RedirectToAction("Index");
        }


        public IActionResult UpdateItem (int id)
        {
            var g = _itemService.GetItem(id);
            if (g==null)
            {
                return NotFound($"Item with {id} does not exist");
            }
            else
            {
                var f = _categoryService.GetCategories();
                ViewData["Categories"] = new SelectList(f.Data, "CategoryId", "Name");
                return View();
            }
          
        }
        [HttpPost]
        public IActionResult UpdateItem (int id,ItemRequestModel requestModel)
        {
            _itemService.UpdateItem(id, requestModel);
            return RedirectToAction("Index");
        }




        public IActionResult Delete (int id)
        {
            var g = _itemService.GetItem(id);
            if (g == null)
            {
                return NotFound($"Item with  id {id} does not exist");
            }
            else
            {
                return View();
            }

        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteItem (int id)
        {
            _itemService.DeleteItem(id);
            return RedirectToAction("Index");
        }




        public IActionResult GetDetails(int id)
        {
          var f = _itemService.GetItem(id);
          if (f==null)
          {
              {
                  return NotFound($"Item with id {id} does not exist");
              }
          }
          return View(f.Data);
        }


    }
}
