using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;

namespace Vidly.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			MovieManager _movieManager = new MovieManager();
//
//			Movie m = new Movie(){Name = "Don't Breathe", Genre = "Crime, Horror, Thriller" };
//
//			bool success = _movieManager.Add(m);

//			Movie updateMovie = new Movie(){Id = 2, Name = "Shawshank Redemption", Genre = "Drama"};
//			bool success = _movieManager.Update(updateMovie);

//			bool success = _movieManager.Delete(5);

//			List<Movie> movies = _movieManager.GetAll();
//			foreach (var movie in movies)
//			{
//				Console.WriteLine(movie.Name);
//			}

//			Movie movie = _movieManager.GetById(1);
//			Console.WriteLine(movie.Name);

			Console.ReadKey();

			CustomerManager _customerManager = new CustomerManager();
//
//			Customer c = new Customer(){Name = "John Wilsy"};
//
//			bool success = _customerManager.Add(c);
		}
	}
}
