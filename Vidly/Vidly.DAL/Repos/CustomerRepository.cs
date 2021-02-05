using System;
using System.Collections.Generic;
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
	}
}
