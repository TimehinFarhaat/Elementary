using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;



        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }



        public CustomerResponseModel CreateCustomer (CustomerRequestModel requestModel)
        {
            var exist = _customerRepository.GetCustomer(requestModel.EmailAddress);
            if (exist != null)
            {

                return new CustomerResponseModel()
                {
                    Status = false,
                    Message = "Customer already exist"
                };
            }
            var customer=new Customer()
            {
                FirstName = requestModel.FirstName,
                LastName = requestModel.LastName,
                EmailAddress = requestModel.EmailAddress,
                PassWord = requestModel.password
            };

            var d = _customerRepository.CreateCustomer(customer);
            if (d == null)
            {
                return new CustomerResponseModel()
                {
                    Message = "Unsuccessful",
                    Status = false,
                };
            }
            
            return new CustomerResponseModel()
            {
                Data = new CustomerDTO()
                {
                    CustomerId = d.Id,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    EmailAddress = d.EmailAddress,
                },
                Message = "Successful",
                Status = true
            };
        }





        public CustomerResponseModel UpdateCustomer (int id, CustomerRequestModel requestModel)
        {
            var customer = _customerRepository.GetCustomer(id);
            if (customer != null)
            {
                {
                    customer.Id = customer.Id;
                    customer.FirstName = requestModel.FirstName;
                    customer.LastName = requestModel.LastName;
                    customer.EmailAddress = requestModel.EmailAddress;
                    customer.PassWord = requestModel.password;

                };
                var d = _customerRepository.UpdateCustomer(customer);
                return new CustomerResponseModel()
                {
                    Data = new CustomerDTO()
                    {
                        CustomerId = d.Id,
                        EmailAddress = d.EmailAddress,
                        FirstName = d.FirstName,
                        LastName = d.LastName
                    },
                    Message = "Successful",
                    Status = true
                };
            }

            return new CustomerResponseModel()
            {
                Message = "Unsuccessful",
                Status = false
            };


        }




        public CustomerResponseModel GetCustomer (int id)
        {
            var g = _customerRepository.GetCustomer(id);
            if (g == null)
            {
                return new CustomerResponseModel()
                {
                    Message = "Not found",
                    Status = false
                };
            }

            return new CustomerResponseModel()
            {
                Message = "Found",
                Status = true,
                Data = new CustomerDTO()
                {
                    CustomerId = g.Id,
                    EmailAddress = g.EmailAddress,
                    FirstName = g.FirstName,
                    LastName = g.LastName,
                    walletId = g.EWallet.Id
                }
            };
        }



        public CustomerResponseModel LoginCustomer(CustomerRequest requestModel)
        {
            {
                var g = _customerRepository.Get(y=>y.EmailAddress ==requestModel.EmailAddress);
                if (g != null && g.PassWord == requestModel.password)
                {
                    return new CustomerResponseModel()
                    {
                        Message = "Found",
                        Status = true,
                        Data = new CustomerDTO()
                        {
                            CustomerId  = g.Id,
                            EmailAddress = g.EmailAddress,
                            FirstName = g.FirstName,
                            LastName = g.LastName
                        }
                    };
                }
                return new CustomerResponseModel()
                {
                    Message = "Not found",
                    Status = false
                };
            }
        }


        public CustomerResponseModels GetAllCustomer ()
        {
            var f = _customerRepository.GetAllCustomer();
            if (f == null)
            {
                return new CustomerResponseModels()
                {
                    Message = "No available Admin",
                    Status = false
                };
            }
            return new CustomerResponseModels()
            {
                Message = "Available",
                Status = true,
                Data = f.Select(b => new CustomerDTO()
                {
                    CustomerId = b.Id,
                    FirstName = b.FirstName,
                    LastName = b.LastName,
                    EmailAddress = b.EmailAddress,
                }).ToList()
            };
        }



        public CustomerResponseModel DeleteCustomer (int id)
        {
            var customer = _customerRepository.GetCustomer(id);
            if (customer == null)
            {
                return new CustomerResponseModel()
                {
                    Message = "Not found",
                    Status = false
                };
            }

            _customerRepository.DeleteCustomer(customer);
            return new CustomerResponseModel()
            {
                Message = "Deleted Succesfully",
                Status = true,
                Data = new CustomerDTO()
                {
                    FirstName = customer.FirstName,
                    CustomerId = customer.Id
                }
            };
        }
    }
}
