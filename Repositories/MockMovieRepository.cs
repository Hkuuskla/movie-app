using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using movie_app.Model;
using movie_app.Repositories.Interfaces;
using Newtonsoft.Json.Serialization;

namespace movie_app.Repositories
{
    public class MockMovieRepository : IMovieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        private readonly IEnumerable<Movie> _moviesList;

        public MockMovieRepository()
        {
            _moviesList = new List<Movie>
            {
                new Movie
                {
                    MovieId = 1,
                    Title = "Gretel & Hansel",
                    Year = "2020",
                    Description =
                        "A long time ago in a distant fairy tale countryside, a young girl leads her little brother "
                        + "into a dark wood in desperate search of food and work, only to stumble upon a nexus of"
                        + " terrifying evil.",
                    Rating = 5,
                    Category = _categoryRepository.GetAllCategories.ToList()[0]
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "Bad Boys for Life",
                    Year = "2020",
                    Description =
                        "Miami detectives Mike Lowrey and Marcus Burnett must face off against a mother-and-son pair"
                        + " of drug lords who wreak vengeful havoc on their city.",
                    Rating = 7,
                    Category = _categoryRepository.GetAllCategories.ToList()[1]
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "Trolls World Tour",
                    Year = "2020",
                    Description =
                        "Poppy and Branch discover that they are but one of six different Troll tribes scattered "
                        + "over six different lands devoted to six different kinds of music: "
                        + "Funk, Country, Techno, Classical, Pop and Rock.",
                    Rating = 6,
                    Category = _categoryRepository.GetAllCategories.ToList()[8]
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "Zootropolis",
                    Year = "2016",
                    Description =
                        "In a city of anthropomorphic animals, a rookie bunny cop and a cynical con artist "
                        + "fox must work together to uncover a conspiracy.",
                    Rating = 8,
                    Category = _categoryRepository.GetAllCategories.ToList()[8]
                },

                new Movie
                {
                    MovieId = 5,
                    Title = "Romance",
                    Year = "1930",
                    Description =
                        "Young Harry is in love and wants to marry an actress, much to the displeasure of his family.",
                    Rating = 6,
                    Category = _categoryRepository.GetAllCategories.ToList()[3]
                }
            };
        }

        public IEnumerable<Movie> GetAllMovies(string query)
        {
            IEnumerable<Movie> AllMovies = _moviesList.Select(movie => new Movie
            {
                MovieId = movie.MovieId,
                Title = movie.Title,
                Year = movie.Year,
                Description = null,
                Rating = movie.Rating,
                Category = movie.Category
            });
            
            return query != null ? AllMovies.Where(movie => movie.Title.ToLower().Contains(query.ToLower())) : AllMovies;
        }


        public Movie GetMovieById(int movieId)
        {
            return _moviesList.FirstOrDefault(m => m.MovieId == movieId);
        }
    }
}