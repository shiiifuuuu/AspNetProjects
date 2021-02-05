using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;

namespace Vidly.ConsoleApp.Models
{
	public class MovieCrudOperation
	{
		static MovieManager _movieManager = new MovieManager();
		public static void MovieAdd()
		{
			Movie m = new Movie(){Name = "The Dark Knight", Genre = "Action, Crime, Drama" };
			bool success = _movieManager.Add(m);
			Console.WriteLine("Success adding a movie in DB");
		}
		public static void MovieUpdate()
		{
			Movie updateMovie = new Movie() { Id = 2, Name = "Shawshank Redemption", Genre = "Drama" };
			bool success = _movieManager.Update(updateMovie);
			Console.Write("Updating movie data Success");
		}
		public static void MovieDelete()
		{
			bool success = _movieManager.Delete(5);
			Console.Write("Deleting a movie data Success");
		}
		public static void MovieGetAll()
		{
			List<Movie> movies = _movieManager.GetAll();
			foreach (var movie in movies)
			{
				Console.WriteLine(movie.Name);
			}
		}
		public static void MovieGetById()
		{
			Movie movie = _movieManager.GetById(1);
			Console.WriteLine(movie.Name);
		}
	}
}
