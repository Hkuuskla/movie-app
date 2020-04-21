using movie_app.Model;
using movie_app.Repositories;
using movie_app.Repositories.Interfaces;
using movie_app.Service.Interfaces;

namespace movie_app.Service
{
    public class MovieService : MockMovieRepository, IMovieService
    {
        
        private readonly IMovieRepository _movieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MovieService(IMovieRepository movieRepository, ICategoryRepository categoryRepository)
        {
            _movieRepository = movieRepository;
            _categoryRepository = categoryRepository;
        }
        
    }
}