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
                "Expiring_Soon int not null",
                "Restock_Required int not null"
            };
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "Pantry", PantryColumns);
                var pan = new Pantry();
                pan.Pantry_Id = 1;
                pan.Name = "Bread Flour";
                pan.Ounces_Consumed = 32.4m;
                pan.Ounces_Remaining = 47.6m;
                pan.Expired = 0;
                pan.Expiring_Soon = 0;
                pan.Restock_Required = 0;
                context.Pantry.Add(pan);
                context.SaveChanges();

                var pantryCount =
                        (from p in context.Pantry
                         select p).Count();
                Assert.AreEqual(1, pantryCount);
            }
        }
        [TestMethod]
        public void CreateAndINsretIntoIngredientConsumptionTable() {
            var db = new DatabaseStuff();
            var IngredientConsumptionColumns = new List<string>() {
                "Id int not null identity(1,1) primary key",
                "Name nvarchar(70) not null",
                "Measurement nvarchar(70) not null",
                "Ounces_Consumed decimal(6,2)"
            };
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "IngredientConsumption", IngredientConsumptionColumns);
                var con = new IngredientConsumption();
                con.Name = "Bread Flour";
                con.Id = 1;
                con.Ounces_Consumed = 32.4m;
                //con.Measurement = "6 cups";
                con.Measurement = "6 cups";
                context.IngredientConsumption.Add(con);
                context.SaveChanges();

                var ingredientConsumptionCount =
                        (from c in context.IngredientConsumption
                         select c).Count();

                Assert.AreEqual(1, ingredientConsumptionCount);
            }
        }
        [TestMethod]
        public void CreateAndInsertIntoCostsTable() {
            var db = new DatabaseStuff();
            var CostsColumns = new List<string>() {
                "Id int not null identity(1,1) primary key",
                "Name nvarchar(70) not null",
                "Selling_Price decimal(6,2) not null",
                "Selling_Weight nvarchar(50) not null",
                "Selling_Weight_Ounces decimal(6,2) not null",
                "Count_Ingredient_Recorded_In_Costs int not null",
                "Average_Price decimal(6,2) not null"
            };
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "Costs", CostsColumns);
                var costs = new Costs();
                costs.Id = 1;
                costs.Name = "Bread Flour";
                costs.Selling_Price = 4.69m;
                costs.Selling_Weight = "5 lb";
                costs.Selling_Weight_Ounces = 80m;
                costs.Count_Ingredient_Recorded_In_Costs = 1;
                costs.Average_Price = 4.69m;
                context.Costs.Add(costs);
                context.SaveChanges();

                var costsCount =
                        (from c in context.Costs
                         select c).Count();

                Assert.AreEqual(1, costsCount);
            }
        }
        [TestMethod]
        public void CreateAndInsertIntoSellingInformationTable() {
            var db = new DatabaseStuff();
            var SellingInformationColumns = new List<string>() {
                "Id int not null identity(1,1) primary key",
                "Name nvarchar(80) not null",
                "Selling_Weight nvarchar(50) not null",
                "Selling_Weight_Ounces decimal(6,2)"
            };
            using (var context = new RachelsRosesMobileDevelopmentEntities()) {
                db.RecreateDatabase(context, "SellingInformation", SellingInformationColumns);
                var SI = new SellingInformation();
                SI.Id = 1;
                SI.Name = "Bread Flour";
                SI.Selling_Weight = "5 lb";
                SI.Selling_Weight_Ounces = 80m;
                context.SellingInformation.Add(SI);
                context.SaveChanges();

                var sellingInformationCount = (from s in context.SellingInformation
                                               select s).Count();
                Assert.AreEqual(1, sellingInformationCount); 
            }
        }
    }
}
