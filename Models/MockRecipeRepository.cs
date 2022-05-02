using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeGist.Models
{
    public class MockRecipeRepository : IRecipeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Recipe> AllRecipes => new List<Recipe> 
        {
            new Recipe { RecipeId = 1, Name = "BBQ Ribs", Description = "Smokey BBQ Ribs", ImageUrl = "", ImageThumbnailUrl = "", Ingredients = "", Instructions = "", IsRecipeOfTheWeek = false, Category = _categoryRepository.AllCategories.ToList()[0], CookingTime = "" },
            new Recipe { RecipeId = 2, Name = "Strawberry Banana Smoothie", Description = "Delicious smoothie made with strawberries and bananas", ImageUrl = "", ImageThumbnailUrl = "", Ingredients = "", Instructions = "", IsRecipeOfTheWeek = false, Category = _categoryRepository.AllCategories.ToList()[1], CookingTime = "" },
            new Recipe { RecipeId = 3, Name = "Cajun rice", Description = "Spicy cajun rice", ImageUrl = "", ImageThumbnailUrl = "", Ingredients = "", Instructions = "", IsRecipeOfTheWeek = false, Category = _categoryRepository.AllCategories.ToList()[2], CookingTime = "" },
        };

        public IEnumerable<Recipe> RecipesOfTheWeek { get; }

        public Recipe GetRecipeById(int recipeId)
        {
            return AllRecipes.FirstOrDefault(r => r.RecipeId == recipeId);
        }
    }
}
