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
//			Customer c = new Customer(){Name = "Merry Williams", MembershipTypeId = 4};
//			Customer c = new Customer(){Name = "Peter Hudson", MembershipTypeId = 2, DoB = new DateTime(1985, 1, 20)};
//			Customer c = new Customer(){Name = "Steve Rogers", MembershipTypeId = 2, DoB = new DateTime(1960, 1, 12)};
			Customer c = new Customer(){Name = "Aria Stark", MembershipTypeId = 2};
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
			List<Customer> customers = _customerManager.GetAllByEagerLoading();
			foreach (var customer in customers)
			{
				var a = customer.DoB;
				if (customer.DoB.Equals(null))
				{
					Console.WriteLine($"{customer.Name} | {customer.MembershipType.Name} | - | -");
				}
				else
				{
					Console.WriteLine($"{customer.Name} | {customer.MembershipType.Name} | {customer.DoB.Value.Year} | {customer.DoB.Value.Month}");
				}
				
			}
		}
		public static void CustomerGetById()
		{
			Customer customer = _customerManager.GetById(1);
			Console.WriteLine(customer.Name);
		}

		public void CustomerBirthDate()
		{
			DateTime dob = new DateTime(1996, 11, 24);
			//			Console.WriteLine(dob.ToLongDateString());
			//			Console.WriteLine(dob);
			DateTime now = DateTime.Today;
			var m = now.Month - dob.Month;
			var y = now.Year - dob.Year;
			int year, month;
			if (m < 0)
			{
				year = y - 1;
				month = m + 12;
			}
			else
			{
				year = y;
				month = m;
			}
			Console.WriteLine($"Birthdate: {dob.ToLongDateString()}");
			Console.WriteLine($"Today: {now.ToLongDateString()}");
			Console.WriteLine($"age: {year} years {month} months (approx.)");
		}
	}
}
