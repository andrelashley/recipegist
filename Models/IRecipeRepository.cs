using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeGist.Models
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> AllRecipes { get; }
        IEnumerable<Recipe> RecipesOfTheWeek { get; }
        Recipe GetRecipeById(int recipeId);
    }
}
