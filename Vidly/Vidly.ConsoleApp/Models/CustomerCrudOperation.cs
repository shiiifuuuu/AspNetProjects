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
//			Membership Types:
//				1 - Pay as you go
//				2 - 1 Month 30$ 10% discount
//				3 - 3 Months 90$ 15% discount
//				4 - 12 Months 300$ 20% discount

//			Customer c = new Customer() { Name = "John Wilsy" };
//			Customer c = new Customer(){Name = "Brad Traversy", MembershipTypeId = 1};
//			Customer c = new Customer(){Name = "John Wisley", MembershipTypeId = 3};
			Customer c = new Customer(){Name = "Merry Williams", MembershipTypeId = 4};
			bool success = _customerManager.Add(c);
			Console.WriteLine("Adding a customer Success");
		}
		public static void CustomerUpdate()
		{
			Customer updateCustomer = new Customer() { Id = 2, Name = "Jerry" };
			bool success = _customerManager.Update(updateCustomer);
			Console.Write("Updating customer data Success");
		}
		public static void CustomerDelete()
		{
			bool success = _customerManager.Delete(5);
			Console.Write("Deleting a customer data Success");
		}
		public static void CustomerGetAll()
		{
			List<Customer> customers = _customerManager.GetAll();
			foreach (var customer in customers)
			{
				Console.WriteLine(customer.Name);
			}
		}
		public static void CustomerGetById()
		{
			Customer customer = _customerManager.GetById(1);
			Console.WriteLine(customer.Name);
		}
	}
}
