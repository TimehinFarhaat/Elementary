using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCE_commerce.DTO;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Controllers
{
    public class CategoryController:Controller
    {
        private readonly ICategory _category;


        public CategoryController(ICategory category)
        {
            _category = category;
        }

        public IActionResult Index ()
        {
            var f = _category.GetCategories();
            return View(f.Data);
        }


        public IActionResult CreateCategory ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory (CategorysRequestModel categoryRequest)
        {
            _category.CreateCategory(categoryRequest);
            return RedirectToAction("Index");
        }



        public IActionResult UpdateCategory (int id)
        {
            var y = _category.GetCategory(id);
            if (y == null)
            {
                return NotFound($" Category with ID:{id} does not exist");
            }
            return View(y.Data);
        }
        [HttpPost]
        public IActionResult UpdateCategory (int id, CategorysRequestModel categoryRequest)
        {
            _category.UpdateCategory(id, categoryRequest);
            return RedirectToAction("Index");
        }




        public IActionResult Delete (int id)
        {
            var y = _category.GetCategory(id);
            if (y == null)
            {
                return NotFound($" Category with ID:{id} does not exist");
            }
            return View(y.Data);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCategory (int id)
        {
            _category.DeleteCategory(id);
            return RedirectToAction("Index");
        }




        public IActionResult GetDetails (int id)
        {
            var f = _category.GetCategory(id);
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
