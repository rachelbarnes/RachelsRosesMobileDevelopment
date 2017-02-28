//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using RachelBarnesMobileDevelopment.Models;
//namespace RachelBarnesMobileDevelopmentTests {
//    [TestClass]
//    public class SplitTests {
//        [TestMethod]
//        public void TestSplitSimpleMeasurement() {
//            var split = new Split();
//            var expected = new string[] { "1", "cup" };
//            var actual = split.SplitMeasurementOrWeightAtSpace("1 cup");
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void TestSPlittSimpleMeasurement2() {
//            var split = new Split();
//            var expected = new string[] { "3", "tablespoons" };
//            var actual = split.SplitMeasurementOrWeightAtSpace("3 tablespoons");
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void TestSplitFractionMeasurement() {
//            var split = new Split();
//            var expected = new string[] { "1 1/2", "tablespoons" };
//            var actual = split.SplitMeasurementOrWeightAtSpace("1 1/2 tablespoons");
//            Assert.AreEqual(expected, actual); 
//        }
//        [TestMethod]
//        public void TestsplitFractionMeasurement2() {
//            var split = new Split();
//            var expected = new string[] { "5 3/4", "cups" };
//            var actual = split.SplitMeasurementOrWeightAtSpace("5 3/4 cups");
//            Assert.AreEqual(expected, actual); 
//        }
//        [TestMethod]
//        public void TestSplitDensity() {
//            var split = new Split();
//            var expected = new string[] { "27", "grams" };
//            var actual = split.SplitMeasurementOrWeightAtSpace("27 grams");
//            Assert.AreEqual(expected, actual); 
//        }
//        [TestMethod]
//        public void TestSplitDensity2() {
//            var split = new Split();
//            var expected = new string[] { "4.5", "gallons" };
//            var actual = split.SplitMeasurementOrWeightAtSpace("4.5 gallons");
//            Assert.AreEqual(expected, actual); 
//        }
//    }
//}
