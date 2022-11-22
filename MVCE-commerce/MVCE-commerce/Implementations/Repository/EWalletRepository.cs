using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class EWalletRepository:IEWalletRepository
    {
        private readonly ApplicationContext _context;

        public EWalletRepository (ApplicationContext context)
        {
            _context = context;
        }


        public Ewallet CreateWallet (Ewallet wallet)
        {
            _context.Ewallets.Add(wallet);
            _context.SaveChanges();
            return wallet;
        }



        public Ewallet UpdateEwallet(Ewallet wallet)
        {                                                                                                                                                                                                           
            _context.Ewallets.Update(wallet);
            _context.SaveChanges();
            return wallet;
        }


        public Ewallet FindEwallet(int id)
        {
            var f = _context.Ewallets.SingleOrDefault(o => o.CustomerId == id);
          return f;

        }
    }
}
