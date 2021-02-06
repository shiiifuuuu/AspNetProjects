using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.DatabaseContext.DatabaseContext;
using Vidly.MODEL.Models;

namespace Vidly.DAL.Repos
{
	public class CustomerRepository
	{
		ProjectDbContext _dbContext = new ProjectDbContext();

		public bool Add(Customer customer)
		{
			_dbContext.Customers.Add(customer);
			return _dbContext.SaveChanges() > 0;
		}

		public bool Update(Customer customer)
		{
			Customer dbCustomer = _dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id);
			dbCustomer.Name = customer.Name;
			return _dbContext.SaveChanges() > 0;
		}

		public bool Delete(int id)
		{
			Customer dbCustomer = _dbContext.Customers.FirstOrDefault(c => c.Id == id);
			_dbContext.Customers.Remove(dbCustomer);
			return _dbContext.SaveChanges() > 0;
		}

		public List<Customer> GetAll()
		{
			return _dbContext.Customers.ToList();
		}

		public Customer GetById(int id)
		{
			Customer dbCustomer = _dbContext.Customers.FirstOrDefault(c => c.Id == id);
			return dbCustomer;
		}

		public List<Customer> GetByEagerLoading()
		{
			return _dbContext.Customers.Include(c => c.MembershipType).ToList();
		}
	}
}
