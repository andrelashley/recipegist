using Microsoft.AspNetCore.Mvc;
using RecipeGist.Models;
using RecipeGist.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace RecipeGist.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RecipeController(IRecipeRepository recipeRepository, ICategoryRepository categoryRepository)
        {
            _recipeRepository = recipeRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    RecipesListViewModel recipesListViewModel = new RecipesListViewModel();
        //    recipesListViewModel.Recipes = _recipeRepository.AllRecipes;
        //    recipesListViewModel.CurrentCategory = "Recipes";

        //    return View(recipesListViewModel);
        //}

        public ViewResult List(string category)
        {

            IEnumerable<Recipe> recipes;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                recipes = _recipeRepository.AllRecipes.OrderBy(r => r.RecipeId);
                currentCategory = "All Recipes";
            }
            else
            {
                recipes = _recipeRepository.AllRecipes.Where(r => r.Category.Name == category)
                    .OrderBy(r => r.RecipeId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.Name == category).Name;
            }

            RecipesListViewModel recipesListViewModel = new RecipesListViewModel();
            recipesListViewModel.Recipes = _recipeRepository.AllRecipes;
            recipesListViewModel.CurrentCategory = "Recipes";

            return View(
                new RecipesListViewModel
                    {
                        CurrentCategory = currentCategory,
                        Recipes = recipes
                    }
                );
        }

        public IActionResult Details(int id)
        {
            var recipe = _recipeRepository.GetRecipeById(id);
            if (recipe == null)
                return NotFound();
            return View(recipe);
        }
    }
}
