using System.ComponentModel.DataAnnotations;

namespace SBMS.Model.Model
{
	public class Category
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		
		[Required]
		[StringLength(10)]
		public string Code { get; set; }
	}
}
