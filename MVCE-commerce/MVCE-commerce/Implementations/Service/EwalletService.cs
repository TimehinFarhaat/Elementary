using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Service
{
    public class EwalletService:IEWalletService
    {
        private readonly IEWalletRepository _eWalletRepository;
        private readonly ICustomerRepository _customerRepository;


        public EwalletService(IEWalletRepository eWalletRepository,ICustomerRepository customerRepository)
        {
            _eWalletRepository = eWalletRepository;
            _customerRepository = customerRepository;
        }



        public EwalletResponseModel CreateWallet (EwalletRequestModel wallet, int id)
        {
            var g = _customerRepository.GetCustomer(id);
            if (g != null)
            {
                var s=new Ewallet()
                {
                    Customer = g,
                    PassWord = wallet.PassWord,
                    Amount = wallet.Amount
                };

                var f = _eWalletRepository.CreateWallet(s);

                return new EwalletResponseModel()
                {
                    Message = "successful",
                    Status = true,
                    Data = new EWalletDTO()
                    {
                        Customer = new CustomerDTO()
                        {
                            CustomerId = g.Id,
                            FirstName = g.FirstName,
                            LastName = g.LastName,
                            EmailAddress =g.EmailAddress
                        },
                        Amount = f.Amount,
                        Id = f.Id
                    }
                };

            }
            return new EwalletResponseModel()
            {
                Message = "Unsuccessful",
                Status = false
            };

        }





        public EwalletResponseModel UpdateEwallet (EwalletRequestModel wallet,int id)
        {
            var s = _customerRepository.GetCustomer(id);
            var g = _eWalletRepository.FindEwallet(id);

            g.Customer = s;
            g.PassWord = wallet.PassWord;
            g.Amount += wallet.Amount;


            var f = _eWalletRepository.UpdateEwallet(g);
            if (f == null)
            {
                return new EwalletResponseModel()
                {
                    Message = "Unsuccessful",
                    Status = false
                };
            }
            return new EwalletResponseModel()
            {
                Message = "successful",
                Status = true,
                Data = new EWalletDTO()
                {
                    Amount = f.Amount,
                    Customer = new CustomerDTO()
                    {
                        CustomerId = g.Id,
                        EmailAddress = s.EmailAddress,
                        LastName = s.LastName,
                        FirstName = s.FirstName,
                    }

                }
            };
        }





        public EwalletResponseModel GetWAllet (int customerId)
        {
            var s = _customerRepository.GetCustomer(customerId);
            var f = _eWalletRepository.FindEwallet(customerId);
            if (s != null)
            {
                return new EwalletResponseModel()
                {
                    Message = "successful",
                    Status = true,
                    Data = new EWalletDTO()
                    {
                        Amount = f.Amount,
                        Customer = new CustomerDTO()
                        {
                            CustomerId = s.Id,
                            EmailAddress = s.EmailAddress,
                            LastName = s.LastName,
                            FirstName = s.FirstName,

                        }

                    }
                };
            }
            return new EwalletResponseModel()
            {
                Message = "Unsuccessful",
                Status = false
            };

        }
    }

}