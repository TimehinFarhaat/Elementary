using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Sales.DTOs.CategoryDTO.RequestModel;
using Sales.DTOs.ItemDTO;
using Sales.DTOs.ResponseModel.ItemResponseModel;
using Sales.Entities;
using Sales.Implementations.Repositories;
using Sales.Interfaces.Repositories;
using Sales.Interfaces.Services;


namespace Sales.Implementations.Sevices
{
    public class ItemService:IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public  ItemService (IItemRepository itemRepository,IWebHostEnvironment webHostEnvironment,ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _itemRepository = itemRepository;
            _webHostEnvironment = webHostEnvironment;
        }


        public ItemResponseModel CreateItem(ItemRequestModel itemRequest)
        {
            var imageName = " ";
            if (itemRequest.Image != null)
            {
                var path = _webHostEnvironment.WebRootPath;
                var imagePath = Path.Combine(path, "My images");
                Directory.CreateDirectory(imagePath);
                var imageType = itemRequest.Image.ContentType.Split('/')[1];
                 imageName = $"{Guid.NewGuid()}.{imageType}";
                var fullPath = Path.Combine(imagePath, imageName);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    itemRequest.Image.CopyTo(fileStream);
                }
            }
          
            var item=new Item()
            {
                    Name = itemRequest.Name,
                    Quantity = itemRequest.Quantity,
                    Price = itemRequest.Price,
                    image = imageName,
            };

            var categories = _categoryRepository.GetsCategory(itemRequest.CategoryIds);
             foreach (var g in categories)
            {
                var itemCategory=new CategoryItem()
                {
                    ItemId = item.Id,
                    CategoryId = g.Id,
                    Item = item,
                    Category = g
                };
                item.CategoryItems.Add(itemCategory);
            }
            var myItem = _itemRepository.Create(item);

            if (myItem==null)
            {
                return new ItemResponseModel()
                {
                    Message = $"{item.Name} not created ",
                    Status = false
                };
            }
            else
            {
                return new ItemResponseModel()
                {
                    Message = $"{item.Name } is created successfully",
                    Status = true,
                    Data = new ItemDtO()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Quantity = item.Quantity,
                        Price = item.Price,
                        Image = imageName,
                    }
                };
            }
        }



        public ItemResponseModels GetAllItems()
        {
            
            var f = _itemRepository.GetItems().Select(b=>new ItemDtO
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Quantity = b.Quantity,
                ItemId = b.Id,
                Image = b.image,

            }).ToList();
            return new ItemResponseModels()
            {
                Data = f,
                Status = true
            };
        }



        public ItemResponseModel DeleteItem(int id)
        {
            var f = _itemRepository.GetItem(id);
            var g = _itemRepository.DeleteItem(f);
            if (g == false)
            {
                return new ItemResponseModel()
                {
                    Message = $" not Deleted ",
                    Status = false
                };

            }
            else
            {
                return new ItemResponseModel()
                {

                    Message = $" Deleted ",
                    Status = true
                };
            }
        }


        public ItemResponseModel UpdateItem(int id, ItemRequestModel itemRequest)
        {
            var imageName = "";
            if (itemRequest.Image != null)
            {
                var path = _webHostEnvironment.WebRootPath;
                var imagePath = Path.Combine(path, "My images");
                Directory.CreateDirectory(imagePath);
                var imageType = itemRequest.Image.ContentType.Split('/')[1];
                imageName = $"{Guid.NewGuid()}.{imageType}";
                var fullPath = Path.Combine(imagePath, imageName);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    itemRequest.Image.CopyTo(fileStream);
                }

            }

            var s = _itemRepository.GetItem(id);
            s.Name = itemRequest.Name;
            s.Price = itemRequest.Price;
            s.Quantity = itemRequest.Quantity;
            s.image = imageName;

              var categories = _categoryRepository.GetsCategory(itemRequest.CategoryIds);
            foreach (var g in categories)
            {
                var itemCategory=new CategoryItem()
                {
                    ItemId = s.Id,
                    CategoryId = g.Id,
                    Item = s,
                    Category = g
                };
                s.CategoryItems.Add(itemCategory);
            }

            var myItem = _itemRepository.UpdateItem(s);

            if (myItem == null)
            {
                return new ItemResponseModel()
                {
                    Message = $"{s.Name} not created ",
                    Status = false
                };
            }
            else
            {
                return new ItemResponseModel()
                {
                    Message = $"{s.Name } is created successfully",
                    Status = true,
                    Data = new ItemDtO()
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Quantity = s.Quantity,
                        Price = s.Price,
                        Image = imageName,
                    }
                };
            }
        }


        public ItemResponseModel GetItem (int id)
        {

            var f = _itemRepository.GetItem(id);
            if (f == null)
            {
                return new ItemResponseModel()
                {
                    Message = $" not created ",
                    Status = false
                };

            }
            else
            {
                return new ItemResponseModel()
                {
                    Message = $"{f.Name } is created successfully",
                    Status = true,
                    Data = new ItemDtO()
                    {
                        Id = f.Id,
                        Name = f.Name,
                        Quantity = f.Quantity,
                        Price = f.Price,

                    }
                };
            }
        }


    }
}
