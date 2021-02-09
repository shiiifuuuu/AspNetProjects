using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.MODEL.Models
{
	public class Movie
	{
		public int Id { get; set; }
		
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		
		[Required]
		public string Genre { get; set; }
		
		[Required]
		[Column(TypeName = "date")]
		[Display(Name = "Release Date")]
		public DateTime ReleaseDate { get; set; }
		
		[Required]
		public DateTime AddedDate { get; set; }
		
		[Required]
		[Display(Name = "Currently In Stock")]
		public int InStock { get; set; }
	}
}
