using Capstone.Models.RecipesList;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Linq.Expressions;

namespace Capstone.Controllers
{
    public class RecipesListController : Controller
    {
        public IActionResult Index()
        {
            var root = new Root();            
            return View(root);
        }

        [HttpPost]
        public IActionResult Recipes(Root root)
        {
            var client = new RestClient($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/complexSearch?query={root.searchTerm}&offset=3&number=4");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "bc64a6f2edmshddecf81036a41a0p135aacjsn0148c3382a48");
            request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            var response = client.Execute(request);
            root = JsonConvert.DeserializeObject<Root>(response.Content);
            return View(root);
        }
    }
}
