using System.Collections;
using System.Collections.Generic;

using movie_app.Model;
using movie_app.Repositories.Interfaces;

namespace movie_app.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, Name = "Horror"},
                new Category {CategoryId = 2, Name = "Comedy"},
                new Category {CategoryId = 3, Name = "Action"},
                new Category {CategoryId = 4, Name = "Romance"},
                new Category {CategoryId = 5, Name = "Drama"},
                new Category {CategoryId = 6, Name = "Crime"},
                new Category {CategoryId = 7, Name = "Fantasy"},
                new Category {CategoryId = 8, Name = "Adventure"},
                new Category {CategoryId = 9, Name = "Animation"}
            };
    }
}