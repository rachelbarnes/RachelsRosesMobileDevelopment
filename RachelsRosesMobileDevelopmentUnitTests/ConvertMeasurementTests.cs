using System;
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
    }
}