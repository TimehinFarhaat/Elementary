using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales.Context;
using Sales.Entities;
using Sales.Interfaces.Repositories;


namespace Sales.Implementations.Repositories
{
    public class ItemRepository:IItemRepository
    {
        private readonly ApplicationContext _context;


        public ItemRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Item Create(Item item)
        {

            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }


        public Item UpdateItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
            return item;
        }



        public bool DeleteItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
            return true;
        }



        public IList<Item> GetItems()
        {
            var t = _context.Items.Include(i=>i.CategoryItems).ToList();
            return t;
        }



        public IList<Item> GetItemsByCategory(int categoryId)
        {
            var s = _context.Items.Include(f => f.CategoryItems.Where(p => p.CategoryId == categoryId)).ToList();
            return s;
        }


       
        public Item GetItem(int id)
        {
            var d = _context.Items.Find(id);
            return d;
        }



        public List<Item> GetItems(List<int> ItemIds)
        {
            var f = _context.Items.Where(i => ItemIds.Contains(i.Id)).ToList();
            return f;
        }


        public IList<Item> GetItemBySelectedCategory (List<int> categoryIds)
        {
            var g = _context.Items.Include(f => f.CategoryItems.Where(i => categoryIds.Contains(i.CategoryId))).ToList();
            return g;
        }
    }
} 
