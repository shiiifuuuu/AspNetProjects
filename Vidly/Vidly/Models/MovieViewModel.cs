using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.MODEL.Models;

namespace Vidly.Models
{
	public class MovieViewModel
	{
//		public MovieViewModel()
//		{
//			Movie = new Movie();
//		}
		public Movie Movie { get; set; }
		public List<Movie> Movies { get; set; }

		public string Title { get; set; }
		public string Heading { get; set; }
	}
}