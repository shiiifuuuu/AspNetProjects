using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.MODEL.Models;

namespace Vidly.MODEL.ValidationModels
{
	class Min18YearsIfAMember: ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var customer = (Customer)validationContext.ObjectInstance;
			if (customer.MembershipTypeId == MembershipType.MemberUnknown ||
			    customer.MembershipTypeId == MembershipType.MemberBasic)
			{
				return ValidationResult.Success;
			}
			var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
			if (age <= 18)
			{
				return new ValidationResult("User Must be 18 years old to use a Membership");
			}
			else
			{
				return ValidationResult.Success;
			}
		}
	}
}
