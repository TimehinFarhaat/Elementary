using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Service;
using MySqlX.XDevAPI;


namespace MVCE_commerce.Controllers
{
    public class CustomerController:Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IEWalletService _eWalletService;
        private readonly IStockProductService _stockProductService;


        public CustomerController(ICustomerService customerService,IEWalletService eWalletService, IStockProductService stockProductService)
        {
            _customerService = customerService;
            _eWalletService = eWalletService;
            _stockProductService = stockProductService;
        }

        public IActionResult Index ()
        {
            var t = _customerService.GetAllCustomer();
            return View(t.Data);
        } 

        public IActionResult ProductList ()
        {
            var t = _stockProductService.GetStockProducts();
            return View(t.Data);
        }



        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login (CustomerRequest customer)
        {
            var t=  _customerService.LoginCustomer(customer);
            ViewBag.Message = t.Message;
            if (t.Status == true)
            {
                HttpContext.Session.SetString("EmailAddress", customer.EmailAddress);
                HttpContext.Session.SetString("FirstName", t.Data.FirstName);
                HttpContext.Session.SetInt32("Ids", t.Data.CustomerId);
                return RedirectToAction("ProductList");
                //return RedirectToAction("Detail" ,new {id = t.Data.CustomerId});
            }
            return View("Login");
        }



        public IActionResult CustomerChoice ()
        {

            return View();
        }




        public IActionResult CustomerPage ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            if (UserId != null)
            {
                var customer = _customerService.GetCustomer(UserId.Value);
                if (customer == null)
                {
                    return NotFound($"Customer with  id {UserId} does not exist");
                }
                return View(customer.Data);

            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }






        public IActionResult AddCustomer ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer (CustomerRequestModel customer)
        {
            var d= _customerService.CreateCustomer(customer);
            ViewBag.Message = d.Message;
            if (d.Status==false)
            {
                return View();
            }         
            return RedirectToAction("CustomerWallet" ,new{id=d.Data.CustomerId});
        }





        public IActionResult CustomerWallet ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerWallet (int id, EwalletRequestModel requestModel)
        {
            var d = _eWalletService.CreateWallet(requestModel, id);
            return RedirectToAction("ProductList");
        }






        public IActionResult UpdateCustomer()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var customer = _customerService.GetCustomer(UserId.Value);
            if (customer == null)
            {
                return NotFound($"Admin with  id {customer.Data.CustomerId} does not exist");
            }
            else
            {
                return View(customer.Data);
            }
        }
        [HttpPost]
        public IActionResult UpdateCustomer ( CustomerRequestModel customer)
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            if (UserId != null)
            {
                _customerService.UpdateCustomer(UserId.Value, customer);
            }

            return RedirectToAction("Index");
        }







        public IActionResult UpdateWallet ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var g = _customerService.GetCustomer(UserId.Value);
            var customer = _eWalletService.GetWAllet(g.Data.walletId);
            if (customer == null)
            {
                return NotFound($"Admin with  id {UserId.Value} does not exist");
            }
            else
            {
                return View(customer.Data);
            }
        }
        [HttpPost]
        public IActionResult UpdateWallet (EwalletRequestModel customer)
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var g = _customerService.GetCustomer(UserId.Value);
            _eWalletService.UpdateEwallet(customer,g.Data.walletId);
            return RedirectToAction("WalletDetails");
        }






        public IActionResult Details ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            if (UserId != null)
            {
                var customer = _customerService.GetCustomer(UserId.Value);
                if (customer == null)
                {
                    return NotFound($"Customer with  id {UserId} does not exist");
                }
                return View(customer.Data);

            }
            else
            {
                return RedirectToAction("Login");
            }
        }









        public IActionResult Detail ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            if (UserId != null)
            {
                var customer = _customerService.GetCustomer(UserId.Value);
                if (customer == null)
                {
                    return NotFound($"Customer with  id {UserId} does not exist");
                }
                return View(customer);

            }
            else
            {
                return RedirectToAction("Login");
            }
        }









        public IActionResult WalletDetails ()
        {

            var UserId = HttpContext.Session.GetInt32("Ids");
            var customer = _eWalletService.GetWAllet(UserId.Value);
            if (customer == null)
            {
                return NotFound($"Customer with  id {UserId.Value} does not exist");
            }
            else
            {
                return View(customer.Data);
            }
        }



        public IActionResult LogOut (AdminRequest admin)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }






        public IActionResult DeleteCustomer ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var customer = _customerService.GetCustomer(UserId.Value);
            if (customer == null)
            {
                return View(customer.Message);
            }
            else
            {
                return View(customer.Data);
            }
        }
        [HttpPost, ActionName("DeleteCustomer")]
        public IActionResult DeleteConfirmed ()
        {
            var UserId = HttpContext.Session.GetInt32("Ids");
            var customer = _customerService.DeleteCustomer(UserId.Value);
           if (customer != null)
           {
               return RedirectToAction("Index");
           }
           else
           {
               return RedirectToAction($"Not Found");
           }
        }









    }
}
