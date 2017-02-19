using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopmentTests {
    [TestClass]
    public class SplitTests {
        [TestMethod]
        public void TestSplitSimpleMeasurement() {
            var split = new Split();
            var expected = new string[] { "1", "cup" };
            var actual = split.SplitSingleMeasurementOrDensity("1 cup");
            Assert.AreEqual(expected[0].Length, actual[0].Length); 
            Assert.AreEqual(expected[1].Length, actual[1].Length);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]); 
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSplitSimpleMeasurement2() {
            var split = new Split();
            var expected = new string[] { "3", "tablespoons" };
            var actual = split.SplitSingleMeasurementOrDensity("3 tablespoons");
            Assert.AreEqual(expected[0].Length, actual[0].Length); 
            Assert.AreEqual(expected[1].Length, actual[1].Length);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]); 
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSplitFractionMeasurement() {
            var split = new Split();
            var expected = new string[] { "1 1/2", "tablespoons" };
            var actual = split.SplitSingleMeasurementOrDensity("1 1/2 tablespoons");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestsplitFractionMeasurement2() {
            var split = new Split();
            var expected = new string[] { "5 3/4", "cups" };
            var actual = split.SplitSingleMeasurementOrDensity("5 3/4 cups");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitDensity() {
            var split = new Split();
            var expected = new string[] { "27", "grams" };
            var actual = split.SplitSingleMeasurementOrDensity("27 grams");
            Assert.AreEqual(expected[0].Length, actual[0].Length); 
            Assert.AreEqual(expected[1].Length, actual[1].Length);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]); 
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSplitDensity2() {
            var split = new Split();
            var expected = new string[] { "4.5", "gallons" };
            var actual = split.SplitSingleMeasurementOrDensity("4.5 gallons");
            CollectionAssert.AreEqual(expected, actual); 
        }
        //split multilevel measurements
        [TestMethod]
        public void TestSplitMultiLevelMeasurement() {
            var split = new Split();
            var expected = new string[] { "1 cup", "2 tablespoons" };
            var actual = split.SplitDoubleLayerMeasurement("1 cup 2 tablespoons");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitMultiLevelMeasurement2() {
            var split = new Split();
            var expected = new string[] { "1 1/2 cups", "3 tablespoons" };
            var actual = split.SplitDoubleLayerMeasurement("1 1/2 cups 3 tablespoons");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitMultiLevelDensity() {
            var split = new Split();
            var expected = new string[] { "1 gallon", "1/2 gallon"};
            var actual = split.SplitDoubleLayerMeasurement("1 gallon 1/2 gallon"); 
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitTripleLevelMeasurement() {
            var split = new Split();
            var expected = new string[] { "1 cup", "1 tablespoon", "1 teaspoon" };
            var actual = split.SplitTripleLayerMeasurement("1 cup 1 tablespoon 1 teaspoon");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitQuadLevelMeasurement() {
            var split = new Split();
            var expected = new string[] { "1 cup", "1 tablespoon", "1 teaspoon", "1 pinch" };
            var actual = split.SplitQuadLayerMeasurement("1 cup 1 tablespoon 1 teaspoon 1 pinch");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitMeasurement1() {
            var split = new Split();
            var expected = new string[] { "1 cup" };
            var actual = split.SplitMeasurementOrDensity("1 cup");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitMeasurement2() {
            var split = new Split();
            var expected = new string[] { "3/4 cup", "1 tablespoon" };
            var actual = split.SplitMeasurementOrDensity("3/4 cup 1 tablespoon");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitMeasurement3() {
            var split = new Split();
            var expected = new string[] { "1 cup", "5 3/4 tablespoon", "1 1/2 teaspoon" };
            var actual = split.SplitMeasurementOrDensity("1 cup 5 3/4 tablespoon 1 1/2 teaspoon");
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestSplitMeasurement4() {
            var split = new Split();
            var expected = new string[] { "12 1/4 cup", "1 tablespoon", "1/3 teaspoon", "2 pinches" };
            var actual = split.SplitMeasurementOrDensity("12 1/4 cup 1 tablespoon 1/3 teaspoon 2 pinches");
            CollectionAssert.AreEqual(expected, actual); 
        }
    }
}
