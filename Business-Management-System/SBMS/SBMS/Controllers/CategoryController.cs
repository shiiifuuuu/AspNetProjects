using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBMS.Manager.Manager;
using SBMS.Models;

namespace SBMS.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager();

        // GET: Category
        public ActionResult Index()
        {
            return View("CategoryList");
        }

        //Create Category
        public ActionResult New()
        {
            CategoryViewModel viewModel = new CategoryViewModel();
	        return View("CategoryForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(CategoryViewModel viewModel)
        {
	        if (viewModel == null)
	        {
		        return HttpNotFound();
	        }

            //New Category
	        if (viewModel.Category.Id == 0)
	        {
		        _categoryManager.Add(viewModel.Category);
	        }
	        //Edit Category
	        else
	        {
		        
	        }
            return RedirectToAction("Index", "Category");
        }
    }
}