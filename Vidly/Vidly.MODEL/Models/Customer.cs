using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.MODEL.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Display(Name = "Membership Types")]
		public byte MembershipTypeId { get; set; }
		
		public MembershipType MembershipType { get; set; }

		[Display(Name = "Date of Birth")]
		public DateTime? BirthDate { get; set; }
	}
}
