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
        MembershipTypeManager _membershipTypeManager = new MembershipTypeManager();

        // GET: Customer
        public ActionResult Index()
        {
	        List<Customer> customers = _customerManager.GetAll();
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

        public ActionResult New()
        {
	        CustomerViewModel viewModel = new CustomerViewModel()
	        {
				Customer = new Customer()
	        };
	        viewModel.Heading = "Add a New Customer";
	        viewModel.Title = "Add Customer";
            viewModel.MembershipTypes = _membershipTypeManager.GetAll();
//          return View(viewModel);
	        return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(CustomerViewModel newViewModel)
        {
	        if (!ModelState.IsValid)
	        {
				CustomerViewModel viewModel = new CustomerViewModel();
				viewModel.MembershipTypes = _membershipTypeManager.GetAll();
				viewModel.Title = "Add Customer";
				viewModel.Heading = "Add a New Customer";

		        return View("CustomerForm", viewModel);
	        }
	        if (newViewModel.Customer.Id == 0)
	        {
		        bool success = _customerManager.Add(newViewModel.Customer);
            }
            else
	        {
		        _customerManager.Update(newViewModel.Customer);
	        }
	        return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
	        CustomerViewModel viewModel = new CustomerViewModel();
	        viewModel.Heading = "Edit/Update Existing Customer";
	        viewModel.Title = "Edit Customer";
	        viewModel.Customer = _customerManager.GetById(id);
	        if (viewModel.Customer == null)
	        {
		        return HttpNotFound();
            }
	        else
	        {
		        viewModel.MembershipTypes = _membershipTypeManager.GetAll();
                return View("CustomerForm", viewModel);
            }
        }
    }
}