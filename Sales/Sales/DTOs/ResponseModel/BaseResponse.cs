using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.DTOs.ResponseModel
{
    public abstract class BaseResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
