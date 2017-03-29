using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelBarnesMobileDevelopment.Models;
using RachelBarnesMobileDevelopment;
namespace RachelBarnesMobileDevelopment.Controllers {
    public class RecipeCollectionController : Controller {
        public ActionResult RecipeCollection() {
            var context = new RachelsRosesMobileDevelopmentEntities();
            var myRecipes = (from r in context.Recipes
                             select r);
            ViewBag.RecipeCollection = myRecipes;
            return View();
        }
        public ActionResult AddARecipe(string name, string yield) {
            var intYield = int.Parse(yield);
            var context = new RachelsRosesMobileDevelopmentEntities();
            var recipeTable = new Recipes();
            recipeTable.Name = name;
            recipeTable.Yield = intYield;
            context.Recipes.Add(recipeTable);
            context.SaveChanges();
            //this is not adding values to the database. :(
            var count = context.Recipes.Count();
            return View();
        }
        public ActionResult DeleteRecipe(string name, string id) {
            var intId = int.Parse(id);
            var context = new RachelsRosesMobileDevelopmentEntities();
            var recipeTable = new Recipes();
            var recipeToRemove = (from r in context.Recipes
                                  where r.Name == name && r.Id == intId
                                  select r).First();
            context.Recipes.Remove(recipeToRemove);
            context.SaveChanges();
            return View();
        }
        public ActionResult EditRecipe(string name, string id, string newName, string newYield) {
            var context = new RachelsRosesMobileDevelopmentEntities();
            var recipeTable = new Recipes();
            var currentRecipe = (from r in context.Recipes
                                 where r.Name == name && r.Id == int.Parse(id) 
                                 select r).First();
            currentRecipe.Name = newName;
            currentRecipe.Yield = int.Parse(newYield);
            context.SaveChanges();
            return View(); 
        }
    }
}