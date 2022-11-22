using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sales.DTOs.CategoryDTO.RequestModel;
using Sales.Interfaces.Services;


namespace Sales.Controllers
{
    public class CategoryController:Controller
    {
        private readonly ICategoryService _categoryService;


        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            var f = _categoryService.GetCategories();
            return View(f.Data);
        }


        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryRequestModel categoryRequest)
        {
            _categoryService.CreateCategory(categoryRequest);
            return RedirectToAction("Index");
        }



        public IActionResult UpdateCategory (int id)
        {
            var y = _categoryService.GetCategory(id);
            if (y==null)
            {
                return NotFound($" Category with ID:{id} does not exist");
            } 
            return View(y.Data);
        }
        [HttpPost]
        public IActionResult UpdateCategory (int id,CategoryRequestModel categoryRequest)
        {
            _categoryService.UpdateCategory(id,categoryRequest);
            return RedirectToAction("Index");
        }




        public IActionResult Delete (int id)
        {
            var y = _categoryService.GetCategory(id);
            if (y == null)
            {
                return NotFound($" Category with ID:{id} does not exist");
            }
            return View(y.Data);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }




        public IActionResult GetDetails(int id)
        {
            var f = _categoryService.GetCategory(id);
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
