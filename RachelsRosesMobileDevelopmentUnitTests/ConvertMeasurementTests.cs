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
            var actual = convert.AggregateTeaspoons("1 tablespoon");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertMeasurementToTeaspoons5() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 48m;
            var actual = convert.AggregateTeaspoons("1 cup");
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
            var actual = convert.AggregateTeaspoons("5 1/8 cup 3 1/2 tablespoons 2 1/4 teaspoons");
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
            var convert = new ConvertMeasurementCalculations();
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
        [TestMethod]
        public void TestAdjustedTeaspoons() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 2m;
            var actual = convert.AdjustedTeaspoons(1m, 2m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdjustedTeaspoons2() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 8.25m;
            var actual = convert.AdjustedTeaspoons(1.5m, 5.5m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdjustedTeaspoons3() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 253.76m;
            var actual = convert.AdjustedTeaspoons(768.96m, .33m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdjustedTeaspoons4() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 60m;
            var actual = convert.AdjustedTeaspoons(10m, 6);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdjustedTeaspoons5() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 33m;
            var actual = convert.AdjustedTeaspoons(3, 11);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdjustedTeaspoons6() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 43.50m;
            var actual = convert.AdjustedTeaspoons(4.5m, "9 2/3");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdjustedTeaspoons7() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 559.41m;
            var actual = convert.AdjustedTeaspoons(55.25m, "10 1/8");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddingDictionaryKeysAndValues() {
            var convert = new ConvertMeasurementCalculations();
            var expected = new Dictionary<string, decimal>();
            expected.Add("cups", 1.5m);
            var actual = new Dictionary<string, decimal>();
            convert.AddMeasurementToDictionary(actual, "cups", 1m);
            convert.AddMeasurementToDictionary(actual, "cups", .5m);
            Assert.AreEqual(expected["cups"], actual["cups"]);
        }
        [TestMethod]
        public void TestCondensementOfMeasurement() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1 teaspoon";
            var actual = convert.CondenseTeaspoonsToMeasurement(1m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCondensementOfMeasurement2() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1 cup 1 tablespoon 1 teaspoon";
            var actual = convert.CondenseTeaspoonsToMeasurement(48m + 3m + 1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondensementOfMeasurement3() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "4 2/3 cups 1 tablespoon 1/2 teaspoons";
            var actual = convert.CondenseTeaspoonsToMeasurement(216m + 9m + 2.5m); //this is written for 4 1/2 cups 3 tablespoons 1/2 teaspoons, but it condensed more efficiently
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondensementOfMeasurement4() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "12 1/2 cups 1 tablespoon 2 1/2 teaspoons";
            var actual = convert.CondenseTeaspoonsToMeasurement(600m + 4.5m + 1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondesementOfMeasurement5() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "2 pinches";
            var actual = convert.CondenseTeaspoonsToMeasurement(.07m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondensementOfMeasurement6() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1 pinch";
            var actual = convert.CondenseTeaspoonsToMeasurement(.05m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCondensementOfMeasurement7() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "12 3/4 cups 1 tablespoon 2 teaspoons 1 pinch";
            var actual = convert.CondenseTeaspoonsToMeasurement(612m + 3m + 2m + .05m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestAdjustMeasurement() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "2 teaspoons";
            var actual = convert.AdjustMeasurement("1 teaspoon", 2m, 1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestAdjustMeasurement2() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "1 tablespoon 1 teaspoon";
            var actual = convert.AdjustMeasurement("2 teaspoons", 4m, 2m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestAdjustMeasurement3() {
            var convert= new ConvertMeasurementCalculations();
            var expected = "29 1/2 cups 1 tablespoon 1/4 teaspoons 1 pinch";
            var actual = convert.AdjustMeasurement("6 1/4 cups 3 tablespoons 1 1/2 teaspoons 1 pinch", 64m, 14m);
            Assert.AreEqual(expected, actual); 
            //total: 300+9+1.5+.06 * 4.57
            //1419.26
                //need to double check this!
        }
        [TestMethod]
        public void TestCondenseMeas() {
            var convert = new ConvertMeasurementCalculations();
            var expected = "?";
            var actual = convert.CondenseTeaspoonsToMeasurement(1419.26m);
            Assert.AreEqual(expected, actual); 
        }
    }
}