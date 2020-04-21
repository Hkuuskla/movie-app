
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using movie_app.Service.Interfaces;

namespace movie_app.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet("/api/movies")]
         
         public JsonResult GetMovies()
         {
             return Json(_movieService.GetAllMovies.ToList());
         }
         
         [HttpGet("/api/movies/{id:int}")]
         
         public JsonResult GetMoviesById(int id)
         {
             return Json(_movieService.GetMovieById(id));
         }


         private readonly IMovieService _movieService;
        

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;

        }

        public ViewResult List()
        {
            var movies = _movieService.GetAllMovies;
            return View(movies);
        }
    }
}