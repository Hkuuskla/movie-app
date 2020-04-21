using System.Collections.Generic;
using movie_app.Model;

namespace movie_app.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}