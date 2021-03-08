using System;
using System.Web.Http;
using SBMS.Manager.Manager;
using SBMS.Model.Model;

namespace SBMS.Api
{
    public class CategoryController : ApiController
    {
	    CategoryManager _categoryManager = new CategoryManager();

		//fetch('/api/category/')
		[HttpGet]
		public IHttpActionResult Get()
		{
			var result = _categoryManager.GetAll();
			if (result != null)
				return Ok(result);
			else
				return NotFound();

		}

		//fetch('/api/category/')
		[HttpPost]
		public IHttpActionResult Post(Category category)
		{
			var result = _categoryManager.Add(category);
			if (result)
				return Created(new Uri($"{Request.RequestUri}/{category.Id}"), category);
			else
				return BadRequest();
		}
    }
}
