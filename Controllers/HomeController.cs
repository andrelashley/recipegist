using Microsoft.AspNetCore.Mvc;
using RecipeGist.Models;
using RecipeGist.ViewModels;

namespace RecipeGist.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeRepository _recipeRepository;

        public HomeController(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                RecipesOfTheWeek = _recipeRepository.RecipesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
