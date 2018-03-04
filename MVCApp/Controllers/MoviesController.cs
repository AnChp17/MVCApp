using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModel;

namespace MVCApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Die Hard" };
            var customers = new List<Customer>()
            {
                new Customer(){ID = 1, Name = "A"},
                new Customer(){ID = 2, Name = "B"}
            };

            var viewmodal = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewmodal);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            List<Movie> moviesList = new List<Movie>()
            {
                new Movie(){ID = 1, Name = "Die Hard1"},
                new Movie(){ID = 2, Name = "Die Hard2"}
            };

            return moviesList;
        }
    }
}