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

		public bool Update(Customer customer)
		{
			return _customerRepository.Update(customer);
		}

		public bool Delete(int id)
		{
			return _customerRepository.Delete(id);
		}

		public List<Customer> GetAll()
		{
			return _customerRepository.GetAll();
		}

		public Customer GetById(int id)
		{
			return _customerRepository.GetById(id);
		}

		public List<Customer> GetAllByEagerLoading()
		{
			return _customerRepository.GetByEagerLoading();
		}

		public Customer GetByIdEagerLoading(int id)
		{
			return _customerRepository.GetByIdEagerLoading(id);
		}
	}
}
