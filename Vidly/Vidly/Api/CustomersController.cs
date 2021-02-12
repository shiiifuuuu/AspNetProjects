using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        CustomerManager _customerManager = new CustomerManager();

        //fetch('/api/customers/')
		[HttpGet]
        public IHttpActionResult Get()
        {
	        var customers = _customerManager.GetAll();
	        if (customers!=null)
	        {
		        return Ok(customers);
			}
	        else
	        {
		        return NotFound();
	        }
		}

		//fetch('/api/customer/1')
		[HttpGet]
        public IHttpActionResult Get(int id)
        {
	        var customer = _customerManager.GetById(id);
	        if (customer != null)
	        {
		        return Ok(customer);
            }
	        else
	        {
		        return NotFound();
	        }
        }

		//fetch('/api/customers/')
		[HttpPost]
        public IHttpActionResult Post(Customer customer)
        {
	        var response = _customerManager.Add(customer);
	        if (response)
	        {
				return Created(new Uri($"{Request.RequestUri}/{customer.Id}"), customer);
			}
	        else
	        {
		        return BadRequest();
	        }
	        
        }

		//fetch('api/customers/1')
		[HttpPut]
		public IHttpActionResult Put(int id, Customer customer)
		{
			var response = _customerManager.Update(customer);
			if (response)
			{
				return Created(new Uri($"{Request.RequestUri}/{customer.Id}"), customer);
			}
			else
			{
				return BadRequest();
			}
		}

		//fetch('api/customers/1')
		[HttpDelete]
		public IHttpActionResult Delete(int id)
		{
			var response = _customerManager.Delete(id);
			if (response)
			{
				return Ok();
			}
			else
			{
				return BadRequest();
			}
		}
    }
}
