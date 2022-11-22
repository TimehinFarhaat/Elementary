using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class TransactionRepository:ITransactionRepository
    {
        private readonly ApplicationContext _context;


        public TransactionRepository (  ApplicationContext context)
        {
            _context = context;
        }



        public Transaction CreateTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            return transaction;
        }


        public Transaction GetTransaction(int ProductId)
        {
            var f = _context.Transactions.Include(t => t.Products).ThenInclude(t => t.ProductId == ProductId).SingleOrDefault();
            return f;
        }
    }
}
