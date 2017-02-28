using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachelBarnesMobileDevelopment.Models;
using RachelBarnesMobileDevelopment.Controllers;
using RachelBarnesMobileDevelopment; 
namespace RachelsRosesMobileDevelopmentUnitTests {
    [TestClass]
    public class IngredientDensityTableDBTests {
        [TestMethod]
        public void InsertIngredientsIntoIngredientDensitiesTable() {
            var IDQ = new IngredientDensityTableQueries();
            IDQ.insertIngredientDensityDictionaryIntoIngredientDensity(); 
            //var IDQ; 

        }
    }
}
