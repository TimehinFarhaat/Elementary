using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.ItemDTO;
using Sales.Entities;


namespace Sales.Interfaces.Repositories
{
    public interface IItemRepository
    {
        Item Create(Item item);
        Item UpdateItem(Item item); 
        bool DeleteItem(Item item);
        IList<Item> GetItems();
        IList<Item> GetItemsByCategory(int categoryId);
        Item GetItem(int id);
      List<Item>  GetItems (List<int>ItemIds);
        IList<Item> GetItemBySelectedCategory(List<int> categoryIds);
    }
}
