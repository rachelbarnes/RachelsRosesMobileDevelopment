using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopmentUnitTests {
    [TestClass]
    public class ConvertTests {
        //the conversions can be done for measurements that have the whole name (cups, tablespoons, teaspoons) or for general abbreviations (c, table, T, tea, t)
        [TestMethod]
        public void ConvertMeasurementToTeaspoons() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 1m;
            var actual = convert.AggregateTeaspoons("1 teaspoon");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons2() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 3m;
            var actual = convert.AggregateTeaspoons("1 tablespoons");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons3() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 48m;
            var actual = convert.AggregateTeaspoons("1 cup");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons4() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 3m;
            var actual = convert.AggregateTeaspoons("1 T");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons5() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 48m;
            var actual = convert.AggregateTeaspoons("1 c");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons6() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 11m;
            var actual = convert.AggregateTeaspoons("3 tablespoons 2 teaspoons");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons7() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 600m;
            var actual = convert.AggregateTeaspoons("12 1/2 cups");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons8() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 187.5m;
            var actual = convert.AggregateTeaspoons("3 3/4 cups 2 tablespoons 1 1/2 teaspoons");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons9() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 258.75m;
            var actual = convert.AggregateTeaspoons("5 1/8 c 3 1/2 T 2 1/4 t"); 
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void MultiplierTest() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 2m;
            var actual = convert.Multiplier(2m, 1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void MultiplierTest2() {
            var convert =new ConvertMeasurementCalculations();
            var expected = .66m;
            var actual = convert.Multiplier(.66m, 1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void MultiplierTest3() {
            var convert = new ConvertMeasurementCalculations();
            var expected = .5m;
            var actual = convert.Multiplier(10, 20);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void MultiplierTest4() {
            var convert = new ConvertMeasurementCalculations();
            var expected = .75m;
            var actual = convert.Multiplier("10 1/2", "14");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplierStringTest() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "3/4";
            var actual = convert.MultiplierString("10 1/2", "14");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplierStringTest2() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1";
            var actual = convert.MultiplierString("14", "14");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplierStringTest3() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1 1/2";
            var actual = convert.MultiplierString(21, 14);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplierStringTest4() {
            var convert = new ConvertMeasurementCalculations();
            var expected = ".3";
            var actual = convert.MultiplierString(6, 20);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplierStringTest5() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1/2";
            var actual = convert.MultiplierString(5.5m, 11m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplierStringTest6() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "8.57";
            var actual = convert.MultiplierString(120m, 14m);
            Assert.AreEqual(expected, actual);
        }

    }
}