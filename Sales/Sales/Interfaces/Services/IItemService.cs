using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.CategoryDTO.RequestModel;
using Sales.DTOs.ItemDTO;
using Sales.DTOs.ResponseModel.ItemResponseModel;


namespace Sales.Interfaces.Services
{
   public interface IItemService
    {
        ItemResponseModel CreateItem(ItemRequestModel itemRequest);
        ItemResponseModels GetAllItems();
        ItemResponseModel GetItem (int id);
        ItemResponseModel DeleteItem (int id);
        ItemResponseModel UpdateItem(int id, ItemRequestModel itemRequest);
    }
}
