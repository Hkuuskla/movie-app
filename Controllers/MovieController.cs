using System.Linq;
using Microsoft.AspNetCore.Mvc;
using movie_app.Service.Interfaces;

namespace movie_app.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet("/api/movies")]
        public JsonResult GetMovies([FromQuery(Name = "query")] string query)
        {
            return Json(_movieService.GetAllMovies(query));
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
        
    }
}