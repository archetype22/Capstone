using Capstone.Models.RecipesInformation;
using Capstone.Models.RecipesList;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace Capstone.Controllers
{
    public class RecipesInformationController : Controller
    {
        
        public IActionResult Info(int id)
        {
            var client = new RestClient($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/{id}/information");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "bc64a6f2edmshddecf81036a41a0p135aacjsn0148c3382a48");
            request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            var response = client.Execute(request);
            var root = JsonConvert.DeserializeObject<Models.RecipesInformation.Root>(response.Content);
            return View(root);
        }
               
      
    }
}
