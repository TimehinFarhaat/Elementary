using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.Context;
using Sales.DTOs.CategoryDTO;
using Sales.Entities;
using Sales.Interfaces.Repositories;


namespace Sales.Implementations.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationContext _context;


        public CategoryRepository (ApplicationContext context)
        {
            _context = context;
        }


        public Category CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }



        public Category UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }



        public bool DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return true;
        }



        public IList<Category> GetAllCategory()
        {
            var g = _context.Categories.ToList();
            return g;
        }


        public IList<CategoryDtO> GetsAllCategory()
        {
            var d = _context.Categories.Include(g => g.CategoryItems)
                            .Select(y => new CategoryDtO()
                             {
                                 CategoryId = y.Id,
                                 Name = y.Name,
                                 Description = y.Description,
                             })
                            .ToList();
            return d;
        }


        public Category GetCategory(int id)
        {
            var e = _context.Categories.Find(id);
            return e;
        }



        //public CategoryDtO GetsCategory(int id)
        //{
        //    var f = _context.Categories.Find(id);
        //    return new CategoryDtO()
        //    {
        //        Name = f.Name,
        //        CategoryId = f.Id,
        //        Description = f.Description,
        //    };
            
        //}


        public IList<Category> GetsCategory (IList<int>categoryids)
        {
            var e = _context.Categories.Where(i=>categoryids.Contains(i.Id)).ToList();
            return e;
        }
    }
}
