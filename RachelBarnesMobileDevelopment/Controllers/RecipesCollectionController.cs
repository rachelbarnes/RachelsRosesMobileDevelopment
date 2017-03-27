using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelBarnesMobileDevelopment.Models;
using RachelBarnesMobileDevelopment;
namespace RachelBarnesMobileDevelopment.Controllers {
    public class RecipesCollectionController : Controller {
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
        public ActionResult DeleteRecipe(string name, string id) {
            var intId = int.Parse(id);
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                var recipeTable = new Recipes();
                var recipeToRemove = (from r in context.Recipes
                                      where r.Name == name && r.Id == intId
                                      select r).First();
                context.Recipes.Remove(recipeToRemove);
                context.SaveChanges();
            }
            return View();
        }
    }
}  