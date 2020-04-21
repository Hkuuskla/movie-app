using System.Collections.Generic;
using movie_app.Model;

namespace movie_app.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies { get; }
        Movie GetMovieById(int movieId);
    }
}