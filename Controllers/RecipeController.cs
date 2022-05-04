using Microsoft.AspNetCore.Mvc;
using RecipeGist.Models;
using RecipeGist.ViewModels;

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

        public ViewResult List()
        {
            RecipesListViewModel recipesListViewModel = new RecipesListViewModel();
            recipesListViewModel.Recipes = _recipeRepository.AllRecipes;
            recipesListViewModel.CurrentCategory = "Recipes";

            return View(recipesListViewModel);
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
