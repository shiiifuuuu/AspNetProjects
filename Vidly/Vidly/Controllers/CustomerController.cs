using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        // GET: Customer
        public ActionResult Index()
        {
//	        List<Customer> customers = _customerManager.GetAll();
	        List<Customer> customers = _customerManager.GetByEagerLoading();
            CustomerViewModel viewModel = new CustomerViewModel();
            
            viewModel.Customers = customers;

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
	        Customer dbCustomer = _customerManager.GetById(id);
	        if (dbCustomer != null)
	        {
		        return View(dbCustomer);
	        }
	        else
	        {
		        return HttpNotFound();
	        }
        }
    }
}