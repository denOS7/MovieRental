using MovieRental.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();

            return View(movies);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            MovieFormViewModel viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            try
            {
                var movie = _context.Movies.Include(c => c.Genre).ToList()[id - 1];
                return View(movie);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return HttpNotFound();
            }
        }
    }
}