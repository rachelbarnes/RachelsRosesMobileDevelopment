using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using RachelBarnesMobileDevelopment;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopment {

    public class IngredientDensityTableQueries {
        public void insertIngredientDensityDictionaryIntoIngredientDensity() {  //Dictionary<string, decimal> ingredientDensityTable) {
            //try {
            var reader = new ReadIngredientDensityFile();
            var myIngredientDensityFile = reader.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename);
            using (var context = new MyRecipesAndIngredientsDatabaseContext()) {
                foreach (KeyValuePair<string, decimal> pair in myIngredientDensityFile) {
                    context.Database.BeginTransaction(); 
                    IngredientDensity IngDen = new IngredientDensity {
                        ingredient_type = pair.Key,
                        density = pair.Value
                    };
                    try {
                        context.IngredientDensities.Add(IngDen);
                        context.SaveChanges();
                    } catch (Exception e) {
                        Console.WriteLine(e);
                        //db.
                    }
                }
            }
        }
        public void InsertIngredientDensityData() {
            var reader = new ReadIngredientDensityFile(); 
            var myIngredientDensityFile = reader.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename);
            using (var context = new MyRecipesAndIngredientsDatabaseContext()) {
                IngredientDensity IngDen = new IngredientDensity() {
                    ingredient_type = "all purpose flour",
                    density = 5m
                };
                context.IngredientDensities.Add(IngDen);
                //context.IngredientDensities.
                context.SaveChanges(); 
            }
        }
    }
}
