using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.DTOs.ItemDTO;


namespace Sales.DTOs.ResponseModel.ItemResponseModel
{
    public class ItemResponseModels:BaseResponse
    {
        public IList<ItemDtO> Data { get; set; }
    }
}
