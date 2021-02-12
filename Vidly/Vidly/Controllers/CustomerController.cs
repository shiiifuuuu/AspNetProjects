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
	        CustomerViewModel viewModel = new CustomerViewModel()
            {
	            Customers = _customerManager.GetAll()
			};
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
		        Heading = "Add a New Customer",
				Title = "Add Customer",
				MembershipTypes = _membershipTypeManager.GetAll()
			};
//          return View(viewModel);
	        return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(CustomerViewModel viewModel)
        {
	        if (!ModelState.IsValid)
	        {
		        viewModel.MembershipTypes = _membershipTypeManager.GetAll();
		        return View("CustomerForm", viewModel);
	        }
	        if (viewModel.Customer.Id == 0)
	        {
		        bool success = _customerManager.Add(viewModel.Customer);
            }
            else
	        {
		        _customerManager.Update(viewModel.Customer);
	        }
	        return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
	        CustomerViewModel viewModel = new CustomerViewModel()
	        {
		        Heading = "Edit/Update Existing Customer",
		        Title = "Edit Customer",
		        Customer = _customerManager.GetById(id)
			};
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


        public JsonResult Delete(int id)
		{
			bool res = _customerManager.Delete(id);
			return Json("", JsonRequestBehavior.AllowGet);
		}
	}
}