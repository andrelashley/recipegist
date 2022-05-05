using RecipeGist.Models;
using System.Collections.Generic;

namespace RecipeGist.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Recipe> RecipesOfTheWeek { get; set; }
    }
}
