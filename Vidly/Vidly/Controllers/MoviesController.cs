using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.BLL.Managers;
using Vidly.MODEL.Models;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		//GET: Movies
		public ActionResult Index()
		{
			MovieManager _movieManager = new MovieManager();
			List<Movie> movies = _movieManager.GetAll();

			MovieViewModel viewModel = new MovieViewModel();
			viewModel.Movies = movies;

			return View(viewModel);
		}
	}
}