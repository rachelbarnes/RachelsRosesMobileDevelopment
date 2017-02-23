using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelBarnesMobileDevelopment.Models; 
namespace RachelBarnesMobileDevelopment.Controllers {
    public class RecipeController : Controller {
        public ActionResult Recipes(List<Recipe> MyRecipes) {
            ViewBag.Recipes = MyRecipes;
            return View(); 
        }
        
    }
}