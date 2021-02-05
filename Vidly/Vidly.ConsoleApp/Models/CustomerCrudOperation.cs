using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;

namespace Vidly.ConsoleApp.Models
{
	public class CustomerCrudOperation
	{
		static CustomerManager _customerManager = new CustomerManager();

		public static void CustomerAdd()
		{
			Customer c = new Customer() { Name = "John Wilsy" };

			bool success = _customerManager.Add(c);

			Console.WriteLine("Adding a customer Success");
		}
	}
}
