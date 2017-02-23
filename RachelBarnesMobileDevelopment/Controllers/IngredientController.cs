using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelBarnesMobileDevelopment.Models; 
namespace RachelBarnesMobileDevelopment.Controllers {
    public class IngredientController : Controller {
        public ActionResult Ingredients(List<Ingredient> MyIngredients) {
            ViewBag.Ingredients = MyIngredients;
            return View(); 
        }
        
    }
}