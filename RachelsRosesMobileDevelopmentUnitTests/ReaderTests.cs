//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using RachelBarnesMobileDevelopment;
//using Microsoft.VisualStudio.TestTools.UnitTesting; 
//namespace RachelsRosesMobileDevelopmentUnitTests {
//    [TestClass]
//    public class ReaderUnitTests {
//        [TestMethod]
//        public void TestReadTextFile() {
//            var readMyFile = new ReadIngredientDensityFile();
//            var expected = new Dictionary<string, decimal>() {
//                {"all purpose flour", 5m }
//            };
//            var actual = readMyFile.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename).First();
//            var actualCount = readMyFile.splitColonDelimitedFileInsertIntoDictionary(ReadIngredientDensityFile.filename).Count(); 
//            var actualKey = actual.Key;
//            var actualValue = actual.Value;
//            Assert.AreEqual("All Purpose Flour", actualKey);
//            Assert.AreEqual(5m, actualValue); 
//            Assert.AreEqual(expected, actual);
//            Assert.AreEqual(82, actualCount); 
//        }
//    }
//}
