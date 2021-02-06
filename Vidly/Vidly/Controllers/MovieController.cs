using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MovieController : Controller
	{
		MovieManager _movieManager = new MovieManager();
		//GET: Movies
		public ActionResult Index()
		{
			List<Movie> movies = _movieManager.GetAll();

			MovieViewModel viewModel = new MovieViewModel();
			viewModel.Movies = movies;

			return View(viewModel);
		}

		public ActionResult Details(int id)
		{
			Movie movie = _movieManager.GetById(id);
			return View(movie);
		}
	}
}