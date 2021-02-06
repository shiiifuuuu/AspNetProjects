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
		public int Id { get; set; }
		public string Name { get; set; }
		public byte MembershipTypeId { get; set; }
		public MembershipType MembershipType { get; set; }
		[Display(Name = "Date of Birth")]
		public DateTime? BirthDate { get; set; }
		public List<Customer> Customers { set; get; }
		public bool IsSubscribeToNewsLetter { get; set; }
	}
}