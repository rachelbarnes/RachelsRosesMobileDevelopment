using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using RachelBarnesMobileDevelopment;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopment {

    public class IngredientDensityTableQueries {
        public void insertIngredientDensityDictionaryIntoIngredientDensity() {  
            var reader = new ReadIngredientDensityFile();
            var myIngredientDensityFile = reader.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename);
            using (var context = new MyRecipesAndIngredientsDatabaseContext()) {
                foreach (KeyValuePair<string, decimal> pair in myIngredientDensityFile) {
                    IngredientDensity IngDen = new IngredientDensity {
                        ingredient_type = pair.Key,
                        density = pair.Value
                    };
                    context.IngredientDensity.Add(IngDen);
                }
                //there's an internal error here
               context.SaveChanges();
            }
        }
        //public void InsertIngredientDensityData() {
        //    var reader = new ReadIngredientDensityFile(); 
        //    var myIngredientDensityFile = reader.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename);
        //    using (var context = new MyRecipesAndIngredientsDatabaseContext()) {
        //        IngredientDensity IngDen = new IngredientDensity() {
        //            ingredient_type = "all purpose flour",
        //            density = 5m
        //        };
        //        context.IngredientDensities.Add(IngDen);
        //        //context.IngredientDensities.
        //        context.SaveChanges(); 
        //    }
        //}
    }
}
