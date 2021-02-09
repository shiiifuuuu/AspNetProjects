using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.MODEL.Models
{
	public class MembershipType
	{
		public byte Id { get; set; }
		
		[Required]
		[StringLength(100)]
		public string Name { get; set; }
		
		[Required]
		public short SignUpFee { get; set; }
		
		[Required]
		public byte DurationInMonths { set; get; }
		
		[Required]
		public byte DiscountRate { get; set; }

		//ForValidations
		public static byte MemberUnknown = 0;
		public static byte MemberBasic = 1;
	}
}
