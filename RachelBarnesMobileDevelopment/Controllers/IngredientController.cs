using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RachelBarnesMobileDevelopment.Models; 
namespace RachelBarnesMobileDevelopment.Controllers {
    public class IngredientsController : Controller {
        public ActionResult Ingredients() {
            var context = new RachelsRosesMobileDevelopmentEntities();
            var myIngredients = (from i in context.Ingredients
                                 select i);
            ViewBag.Ingredients = myIngredients;
            return View(); 
        }
        public ActionResult AddNewIngredient(string name, string weight, string price, string classification, string type) {
            var context = new RachelsRosesMobileDevelopmentEntities();
            var ingredientToAdd = new Ingredients();
            ingredientToAdd.Name = name;
            ingredientToAdd.Selling_Weight = weight;
            ingredientToAdd.Classification = classification;
            ingredientToAdd.Type = type;
            context.Ingredients.Add(ingredientToAdd);
            var ingredientPriceToAdd = new Costs();
            ingredientPriceToAdd.Name = name;
            ingredientPriceToAdd.Selling_Price = decimal.Parse(price);
            ingredientPriceToAdd.Selling_Weight = weight;
            context.Costs.Add(ingredientPriceToAdd);
            context.SaveChanges();
            return View(); 
        }
    }
}