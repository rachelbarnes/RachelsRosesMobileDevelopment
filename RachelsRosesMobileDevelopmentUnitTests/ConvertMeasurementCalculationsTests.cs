﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachelBarnesMobileDevelopment.Models;

namespace RachelBarnesMobileDevelopmentTests{
    [TestClass]
    public class ConversionDensityTests { 
        //teaspoon calculation tests (teapsoons => tablespoons; teaspoons => cups)
        [TestMethod]
        public void ConvertTeaspoonsToTablespoons() {
            var convert = new ConvertMeasurement();
            var expected = 1m;
            var actual = convert.ConvertTeaspoonsToTablespoons(3m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertTeaspoonsToTablespoons2() {
            var convert = new ConvertMeasurement();
            var expected = .33m;
            var actual = convert.ConvertTeaspoonsToTablespoons(1m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertTeaspoonToCups() {
            var convert = new ConvertMeasurement();
            var expected = 1m;
            var actual = convert.ConvertTeaspoonsToCups(48m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertTeaspoonToCups2() {
            var convert = new ConvertMeasurement();
            var expected = .5m;
            var actual = convert.ConvertTeaspoonsToCups(24m);
            Assert.AreEqual(expected, actual);
        }
        //tablepsoon calculation tests (tablespoons => teaspoons; tablespoons => cups)
        [TestMethod]
        public void ConvertTablespoonsToTeaspoons() {
            var convert = new ConvertMeasurement();
            var expected = .99m;
            var actual = convert.ConvertTablespoonsToTeaspoons(.33m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertTablespoonsToTeaspoons2() {
            var convert = new ConvertMeasurement();
            var expected = 6m;
            var actual = convert.ConvertTablespoonsToTeaspoons(2m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertTablespoonsToCups() {
            var convert = new ConvertMeasurement();
            var expected = 1m;
            var actual = convert.ConvertTablespoonsToCups(16m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertTablespoonsToCups2() {
            var convert = new ConvertMeasurement();
            var expected = 6m;
            var actual = convert.ConvertTablespoonsToCups(96m);
            Assert.AreEqual(expected, actual);
        }
        //cup calculation tests (cups => teaspoons; cups => tablespoons)
        [TestMethod]
        public void ConvertCupsToTeaspoons() {
            var convert = new ConvertMeasurement();
            var expected = 48m;
            var actual = convert.ConvertCupsToTeaspoons(1m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertCupsToTeaspoons2() {
            var convert = new ConvertMeasurement();
            var expected = 12m;
            var actual = convert.ConvertCupsToTeaspoons(.25m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertCupsToTablespoons() {
            var convert = new ConvertMeasurement();
            var expected = 16m;
            var actual = convert.ConvertCupsToTablespoons(1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertCupsToTablespoons2() {
            var convert = new ConvertMeasurement();
            var expected = 8m;
            var actual = convert.ConvertCupsToTablespoons(.5m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertPinchesToTeaspoons() {
            var convert = new ConvertMeasurement();
            var expected = .06m;
            var actual = convert.ConvertPinchesToTeaspoons(1m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertPinchesToTeaspoons2() {
            var convert = new ConvertMeasurement();
            var expected = .52m;
            var actual = convert.ConvertPinchesToTeaspoons(8.33m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertTeaspoonsToPinches() {
            var convert = new ConvertMeasurement();
            var expected = 16m;
            var actual = convert.ConvertTeaspoonsToPinches(1m);
            Assert.AreEqual(expected, actual); 
        }
        //test convert a measurement to densities
        [TestMethod]
        public void ConvertOuncesToOunces() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 15.5m;
            var actual = convert.ConvertWeightToOunces("15.5 ounces");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertLbsToOunces() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 16m;
            var actual = convert.ConvertWeightToOunces("1 lb");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertLbsToOunces2() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 89.6m;
            var actual = convert.ConvertWeightToOunces("5.6 pounds");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ConvertGallonToOunces() {
            var convert = new ConvertMeasurementCalculations();
            var expected = 192m;
            var actual = convert.ConvertWeightToOunces("1 1/2 gallons");
            Assert.AreEqual(expected, actual); 
        }
    }
}