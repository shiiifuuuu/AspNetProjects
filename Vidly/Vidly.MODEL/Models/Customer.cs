using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.MODEL.ValidationModels;

namespace Vidly.MODEL.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		[Display(Name = "Membership Types")]
		public byte MembershipTypeId { get; set; }
		
		public MembershipType MembershipType { get; set; }

		[Required]
		[Column(TypeName = "date")]
		[Display(Name = "Date of Birth")]
		[Min18YearsIfAMember]
		public DateTime? BirthDate { get; set; }
	}
}
