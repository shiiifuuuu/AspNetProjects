using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.DAL.Repos;
using Vidly.MODEL.Models;

namespace Vidly.BLL.Managers
{
	public class MovieManager
	{
		MovieRepository _movieRepository = new MovieRepository();

		public bool Add(Movie movie)
		{
			return _movieRepository.Add(movie);
		}

		public bool Update(Movie movie)
		{
			return _movieRepository.Update(movie);
		}

		public bool Delete(int id)
		{
			return _movieRepository.Delete(id);
		}

		public List<Movie> GetAll()
		{
			return _movieRepository.GetAll();
		}

		public Movie GetById(int id)
		{
			return _movieRepository.GetById(id);
		}
		public List<Genre> GetAllGenre()
		{
			return _movieRepository.GetAllGenre();
		}
	}
}
