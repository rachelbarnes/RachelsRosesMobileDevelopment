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
                IngDen.Name= "all purpose flour";
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
                IngDen.Name= "bread flour";
                IngDen.Density = 5.4m;
                context.IngredientDensities.Add(IngDen);
                context.SaveChanges();

                var densitiesCount =
                        (from d in context.IngredientDensities
                         select d).Count();

                Assert.AreEqual(1, densitiesCount); 
            }
        }
    }
}
