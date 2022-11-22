using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class CategoryRepository:ICategoryRepository
    {


        private readonly ApplicationContext _context;


        public CategoryRepository (ApplicationContext context)
        {
            _context = context;
        }


        public Category CreateCategory (Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }



        public Category UpdateCategory (Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }



        public bool DeleteCategory (Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return true;
        }



        public IList<Category> GetAllCategory ()
        {
            var g = _context.Categories.ToList();
            return g;
        }


     

        public Category GetCategory (int id)
        {
            var e = _context.Categories.Include(o=>o.CategoryProducts).ThenInclude(i=>i.Products).FirstOrDefault(o=>o.Id==id);
            return e;
        }



        public IList<Category> GetsCategory(IList<int> Ids)
        {
            var categorys = _context.Categories.Where(t => Ids.Contains(t.Id)).ToList();
            return categorys;
        }
    }
}
