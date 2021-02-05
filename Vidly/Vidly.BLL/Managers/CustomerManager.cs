using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.DAL.Repos;
using Vidly.MODEL.Models;

namespace Vidly.BLL.Managers
{
	public class CustomerManager
	{
		CustomerRepository _customerRepository = new CustomerRepository();

		public bool Add(Customer customer)
		{
			return _customerRepository.Add(customer);
		}
	}
}
