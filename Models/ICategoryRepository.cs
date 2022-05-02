using System.Collections.Generic;

namespace RecipeGist.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
