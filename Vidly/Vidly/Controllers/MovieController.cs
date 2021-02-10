using System;
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

			MovieViewModel viewModel = new MovieViewModel() {Movies = movies};

			return View(viewModel);
		}

		public ActionResult Details(int id)
		{
			Movie movie = _movieManager.GetById(id);
			return View(movie);
		}

		public ActionResult New()
		{
			MovieViewModel viewModel = new MovieViewModel()
			{
				Title = "Add Movie", 
				Heading = "Add a new Movie",
			};

			return View("MovieForm", viewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Save(MovieViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				return View("MovieForm", viewModel);
			}
			//ADDING MOVIE
			if (viewModel.Movie.Id == 0)
			{
				bool success = _movieManager.Add(viewModel.Movie);
			}
			//EDITING EXISTING MOVIE
			else
			{
				bool success = _movieManager.Update(viewModel.Movie);
			}
			return RedirectToAction("Index", "Movie");
		}

		public ActionResult Edit(int id)
		{
			Movie dbMovie = _movieManager.GetById(id);
			MovieViewModel viewModel = new MovieViewModel()
			{
				Movie = dbMovie,
				Title = "Edit Movie",
				Heading = "Edit/Update this Movie"
		};

			return View("MovieForm", viewModel);
		}
	}
}