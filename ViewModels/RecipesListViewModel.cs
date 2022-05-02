using RecipeGist.Models;
using System.Collections.Generic;

namespace RecipeGist.ViewModels
{
    public class RecipesListViewModel
    {
        public IEnumerable<Recipe> Recipes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
