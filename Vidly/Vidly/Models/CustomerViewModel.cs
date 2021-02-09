using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.MODEL.Models;

namespace Vidly.Models
{
	public class CustomerViewModel
	{
		public Customer Customer { get; set; }

		//Views
		public bool IsSubscribeToNewsLetter { get; set; }
		public List<Customer> Customers { set; get; }
		public IEnumerable<MembershipType> MembershipTypes { set; get; }
		public string Heading { get; set; }
		public string Title { get; set; }
	}
}