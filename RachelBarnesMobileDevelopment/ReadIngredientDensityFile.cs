using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using RachelBarnesMobileDevelopment.Controllers;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopment {
    public class ReadIngredientDensityFile {
        public static string filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRosesMobileDevelopment\RachelBarnesMobileDevelopment\IngredientDensitiesTxtFIle.txt";
        public Dictionary<string, decimal> splitColonDelimitedFileInsertIntoDictionary(string filename) {
            var convertMeasurement = new ConvertMeasurementCalculations();
            var capitalize = new Capitalize();
            var insertIntoDictionary = new ConvertMeasurementCalculations(); 
            var line = "";
            var ingredientDensityDictionary = new Dictionary<string, decimal>();
            using (var reader = new StreamReader(filename)) {
                while ((line = reader.ReadLine()) != null) {
                    if (line.Contains(':')) {
                        var lineSplitAtColon = line.Split(':');
                        var ingredientName = capitalize.capitalizeFirstLetterOfEachWord(lineSplitAtColon[0].Trim());
                        var ingredientDensity = lineSplitAtColon[1].Trim();
                        insertIntoDictionary.AddMeasurementToDictionary(ingredientDensityDictionary, ingredientName, decimal.Parse(ingredientDensity)); 
                        //ingredientDensityDictionary.Add(capitalize.capitalizeFirstLetterOfEachWord(ingredientName), decimal.Parse(ingredientDensity));
                    }
                }
            }
            return ingredientDensityDictionary;
        }
    }
}