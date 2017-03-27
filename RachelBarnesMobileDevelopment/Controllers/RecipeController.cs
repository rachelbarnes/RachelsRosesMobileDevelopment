using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelBarnesMobileDevelopment.Models;
using RachelBarnesMobileDevelopment; 
namespace RachelBarnesMobileDevelopment.Controllers {
    public class RecipeController : Controller {
        public ActionResult Recipes() {
            var context = new RachelsRosesMobileDevelopmentEntities();
            var myRecipes = (from r in context.Recipes
                             select r);
            ViewBag.Recipes = myRecipes; 
            return View(); 
        }
        public ActionResult AddARecipe(string name, string yield, List<string> ingredients) {
            var intYield = int.Parse(yield);
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                var recipeTable = new Recipes();
                recipeTable.Name = name;
                recipeTable.Yield = intYield;
                context.Recipes.Add(recipeTable);
                context.SaveChanges();  
            }
            return View(); 
        }
    }
}