﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RachelBarnesMobileDevelopment.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult IDTest() {
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                var db = new DatabaseStuff();
                db.RecreateDatabase(context);
                var IngDen = new IngredientDensities();
                try {
                    IngDen.Name= "all purpose flour";
                    IngDen.Density= 5m;
                    //context.IngredientDensities.Add(IngDen);
                    context.IngredientDensities.Add(IngDen);
                    context.SaveChanges();
                } catch (Exception e) {
                    ViewBag.InnerExceptionMessage = e.ToString();
                }
                return View();
            }
        }
    }
}
//abstractvar reader = new ReadIngredientDensityFile();
//var myIngredientDensityFile = reader.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename);
//   using (var context = new MyRecipesAndIngredientsDatabaseContext()) {
//foreach (KeyValuePair<string, decimal> pair in myIngredientDensityFile) {
//   IngredientDensity IngDen = new IngredientDensity {
//       ingredient_type = pair.Key,
//       density = pair.Value
//   };
//context.IngredientDensities.Add(IngDen);
//}

//context.SaveChanges();
//   }