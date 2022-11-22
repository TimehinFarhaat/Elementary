using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
    public interface ITransactionRepository
    {
        Transaction CreateTransaction (Transaction transaction);
        
        Transaction GetTransaction (int   ProductId);
    }
}
