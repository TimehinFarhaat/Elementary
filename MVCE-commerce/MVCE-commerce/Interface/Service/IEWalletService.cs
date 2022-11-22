using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Inetrface.Service
{
  public  interface IEWalletService
    {
        EwalletResponseModel CreateWallet (EwalletRequestModel  wallet,int id);
       EwalletResponseModel UpdateEwallet (EwalletRequestModel wallet,int id);
       EwalletResponseModel GetWAllet(int customerId);
    }
}
