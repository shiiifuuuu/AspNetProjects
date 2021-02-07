using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.DatabaseContext.DatabaseContext;
using Vidly.MODEL.Models;

namespace Vidly.DAL.Repos
{
	public class MovieRepository
	{
		ProjectDbContext _dbContext = new ProjectDbContext();

		public bool Add(Movie movie)
		{
			_dbContext.Movies.Add(movie);
			return _dbContext.SaveChanges() > 0;
		}

		public bool Update(Movie movie)
		{
			Movie dbMovie = _dbContext.Movies.FirstOrDefault(c => c.Id == movie.Id);

			dbMovie.Name = movie.Name;
			dbMovie.AddedDate = movie.AddedDate;
			dbMovie.Genre = movie.Genre;
			dbMovie.InStock = movie.InStock;
			dbMovie.ReleaseDate = movie.ReleaseDate;

			return _dbContext.SaveChanges() > 0;
		}

		public bool Delete(int id)
		{
			Movie dbMovie = _dbContext.Movies.FirstOrDefault(c => c.Id == id);
			_dbContext.Movies.Remove(dbMovie);
			return _dbContext.SaveChanges() > 0;
		}

		public List<Movie> GetAll()
		{
			return _dbContext.Movies.ToList();
		}

		public Movie GetById(int id)
		{
			return _dbContext.Movies.FirstOrDefault(m => m.Id == id);
		}
	}
}
