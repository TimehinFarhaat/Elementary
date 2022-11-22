using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
    public interface IEWalletRepository
    {
        Ewallet CreateWallet (Ewallet wallet);
        Ewallet  UpdateEwallet (Ewallet wallet);
        Ewallet FindEwallet (int id);
    }
}
