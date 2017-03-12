using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachelBarnesMobileDevelopment;

namespace IntegrationTests {
    [TestClass]
    public class BasicDBRoundTripTest {
        [TestMethod]
        public void CreateAndInsertIntoIngredientDensities() {
            var db = new DatabaseStuff();
            //this is testing the recreation of the database,a nd that the row was inserted. 
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context);
                var IngDen = new IngredientDensities();
                IngDen.Name = "all purpose flour";
                IngDen.Density = 5m;
                context.IngredientDensities.Add(IngDen);
                context.SaveChanges();

                var densities =
                    (from d in context.IngredientDensities
                     select d).Count();

                Assert.AreEqual(1, densities);
            }
        }
        [TestMethod]
        public void CreateAndInsertIntoIngredientDensities2() {
            var db = new DatabaseStuff();
            var IngredientDensityColumns = new List<string>() {
                "Id int not null identity(1,1) primary key",
                "Name nvarchar(60)",
                "Density decimal(5,2)"
            };
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "IngredientDensities", IngredientDensityColumns);
                var IngDen = new IngredientDensities();
                IngDen.Name = "bread flour";
                IngDen.Density = 5.4m;
                context.IngredientDensities.Add(IngDen);
                context.SaveChanges();
                var densitiesCount =
                        (from d in context.IngredientDensities
                         select d).Count();
                Assert.AreEqual(1, densitiesCount);
            }
        }
        [TestMethod]
        public void CreateAndInsertIntoIngredientsTable() {
            var db = new DatabaseStuff();
            var IngredientsColumns = new List<string>() {
                "Id int not null identity(1,1) primary key",
                "Name nvarchar(70)",
                "Recipe_Id int",
                "Measurement nvarchar(70)",
                "Type nvarchar(50)",
                "Classification nvarchar(50)",
                "Selling_Weight nvarchar(50)"
            };
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "Ingredients", IngredientsColumns);
                var Ing = new Ingredients();
                Ing.Id = 1;
                Ing.Name = "Bread Flour";
                Ing.Measurement = "6 cups"; 
                Ing.Selling_Weight = "5 lb";
                Ing.Recipe_Id = 1;
                Ing.Type = "Bread Flour";
                context.Ingredients.Add(Ing);
                context.SaveChanges();

                var ingredientsCount =
                        (from i in context.Ingredients
                         select i).Count();
                Assert.AreEqual(1, ingredientsCount);
            }
            [TestMethod]
            public void CreateAndInsertIntoPantryTable() {
            var db = new DatabaseStuff();
            var PantryColumns = new List<string>() {
                "Pantry_Id int not null identity(1,1) primary key",
                "Name nvarchar(60) not null",
                "Ounces_Consumed decimal(6,2) not null",
                "Ounces_Remaining decimal(6,2) not null",
                "Expired int not null",
                "Expiring_Soon int not null"
            };using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "Pantry", PantryColumns);
                var pan = new Pantry();
                pan.Pantry_Id = 1;
                pan.Name = "Bread Flour"
            }
        }
    }
}
