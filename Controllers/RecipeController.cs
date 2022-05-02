using Microsoft.AspNetCore.Mvc;
using RecipeGist.Models;

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
            return View(_recipeRepository.AllRecipes);
        }
    }
}
