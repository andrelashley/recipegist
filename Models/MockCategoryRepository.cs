using System;
using System.Collections.Generic;

namespace RecipeGist.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
             new Category { CategoryId = 1, Name = "Meat Dishes", Description = "Meat recipe collection" },
             new Category { CategoryId = 2, Name = "Smoothies", Description = "Smoothie recipe collection" },
             new Category { CategoryId = 1, Name = "Side Dishes", Description = "Side dish recipe collection" },
        };
    }
}
