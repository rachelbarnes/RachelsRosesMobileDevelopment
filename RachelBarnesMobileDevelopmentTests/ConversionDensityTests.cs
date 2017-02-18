//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using RachelBarnesMobileDevelopment.Models;
//namespace RachelBarnesMobileDevelopmentTests {
//    [TestClass]
//    public class ConvertDensityTests {
//        //ounces calculation tests
//        [TestMethod]
//        public void ConvertOuncesToGrams() {
//            var convert = new ConvertDensities();
//            var expected = 28.35m;
//            var actual = convert.ConvertOuncesToGrams(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertOuncesToGrams2() {
//            var convert = new ConvertDensities();
//            var expected = 468.62m;
//            var actual = convert.ConvertOuncesToGrams(16.53m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertOuncesToLbs() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertOuncesToLbs(16m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertOuncesToLbs2() {
//            var convert = new ConvertDensities();
//            var expected = .5m;
//            var actual = convert.ConvertOuncesToLbs(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        //grams conversion tests
//        [TestMethod]
//        public void ConvertGramsToLbs() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertGramsToLbs(453.592m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGramsToLbs2() {
//            var convert = new ConvertDensities();
//            var expected = 14.23m;
//            var actual = convert.ConvertGramsToLbs(6454.6194m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGramsToOunces() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertGramsToOunces(28.3495m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGramsToOunces2() {
//            var convert = new ConvertDensities();
//            var expected = 59.63m;
//            var actual = convert.ConvertGramsToOunces(1690.4821m);
//            Assert.AreEqual(expected, actual);
//        }
//        //lbs conversion tests
//        [TestMethod]
//        public void ConvertLbsToOunces() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertLbsToOunces(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertLbsToOunces2() {
//            var convert = new ConvertDensities();
//            var expected = 40m;
//            var actual = convert.ConvertLbsToOunces(2.5m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertLbsToGrams() {
//            var convert = new ConvertDensities();
//            var expected = 453.59m;
//            var actual = convert.ConvertLbsToGrams(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertLbsToGrams2() {
//            var convert = new ConvertDensities();
//            var expected = 2385.89m;
//            var actual = convert.ConvertLbsToGrams(5.26m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertLbsToGrams3() {
//            var convert = new ConvertDensities();
//            var expected = 70873.75m;
//            var actual = convert.ConvertLbsToGrams(156.25m);
//            Assert.AreEqual(expected, actual);
//        }
//        //gallon conversions
//        [TestMethod]
//        public void ConvertGallonsToOunces() {
//            var convert = new ConvertDensities();
//            var expected = 128m;
//            var actual = convert.ConvertGallonsToOunces(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToOunces2() {
//            var convert = new ConvertDensities();
//            var expected = 192m;
//            var actual = convert.ConvertGallonsToOunces(1.5m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToHalfGallon() {
//            var convert = new ConvertDensities();
//            var expected = 2m;
//            var actual = convert.ConvertGallonsToHalfGallon(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToHalfGallon2() {
//            var convert = new ConvertDensities();
//            var expected = 3m;
//            var actual = convert.ConvertGallonsToHalfGallon(1.5m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToQuarts() {
//            var convert = new ConvertDensities();
//            var expected = 4m;
//            var actual = convert.ConvertGallonsToQuarts(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToQuarts2() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertGallonsToQuarts(4m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToPints() {
//            var convert = new ConvertDensities();
//            var expected = 8m;
//            var actual = convert.ConvertGallonsToPints(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToPints2() {
//            var convert = new ConvertDensities();
//            var expected = 32m;
//            var actual = convert.ConvertGallonsToPints(4m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToCups() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertGallonsToCups(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertGallonsToCups2() {
//            var convert = new ConvertDensities();
//            var expected = 100m;
//            var actual = convert.ConvertGallonsToCups(6.25m);
//            Assert.AreEqual(expected, actual);
//        }
//        //half gallon conversions
//        [TestMethod]
//        public void ConvertHalfGallonToGallon() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertHalfGallonToGallon(2m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertHalfGallonToGallon2() {
//            var convert = new ConvertDensities();
//            var expected = 4m;
//            var actual = convert.ConvertHalfGallonToGallon(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertHalfGallonToPint() {
//            var convert = new ConvertDensities();
//            var expected = 2m;
//            var actual = convert.ConvertHalfGallonToPint(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertHalfGallonToPint2() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertHalfGallonToPint(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertHalfGallonToCups() {
//            var convert = new ConvertDensities();
//            var expected = 4m;
//            var actual = convert.ConvertHalfGallonToCups(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertHalfGallonToCups2() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertHalfGallonToCups(4m);
//            Assert.AreEqual(expected, actual);
//        }
//        //pint conversions
//        [TestMethod]
//        public void ConvertPintToCups() {
//            var convert = new ConvertDensities();
//            var expected = 2m;
//            var actual = convert.ConvertPintsToCups(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintToCups2() {
//            var convert = new ConvertDensities();
//            var expected = 64m;
//            var actual = convert.ConvertPintsToCups(32m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintsToGallons() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertPintsToGallons(8);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintsToGallons2() {
//            var convert = new ConvertDensities();
//            var expected = 12m;
//            var actual = convert.ConvertPintsToGallons(96m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintsToHalfGallons() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertPintsToGallons(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintsToHalfGallons2() {
//            var convert = new ConvertDensities();
//            var expected = 6m;
//            var actual = convert.ConvertPintsToGallons(48m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintsToQuarts() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertPintsToQuarts(2m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertPintsToQuarts2() {
//            var convert = new ConvertDensities();
//            var expected = 8m;
//            var actual = convert.ConvertPintsToQuarts(16m);
//            Assert.AreEqual(expected, actual);
//        }
//        //quart conversions
//        [TestMethod]
//        public void ConvertQuartsToGallons() {
//            var convert = new ConvertDensities();
//            var expected = .25m;
//            var actual = convert.ConvertQuartToGallon(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertQuartsToGallons2() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertQuartToGallon(4m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertQuartsToPints() {
//            var convert = new ConvertDensities();
//            var expected = 2m;
//            var actual = convert.ConvertQuartToPints(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertQuartsToPints2() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertQuartToPints(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertQuartsToCups() {
//            var convert = new ConvertDensities();
//            var expected = 4m;
//            var actual = convert.ConvertQuartToCups(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertQuartsToCups2() {
//            var convert = new ConvertDensities();
//            var expected = .5m;
//            var actual = convert.ConvertQuartToCups(.125m);
//            Assert.AreEqual(expected, actual);
//        }
//        //cup conversions
//        [TestMethod]
//        public void ConvertCupsToPints() {
//            var convert = new ConvertDensities();
//            var expected = .5m;
//            var actual = convert.ConvertCupsToPints(1m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToPints2() {
//            var convert = new ConvertDensities();
//            var expected = 18m;
//            var actual = convert.ConvertCupsToPints(36m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToQuarts() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertCupsToQuarts(4m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToQuarts2() {
//            var convert = new ConvertDensities();
//            var expected = 2m;
//            var actual = convert.ConvertCupsToQuarts(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToHalfGallon() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertCupsToHalfGallon(8m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToHalfGallon2() {
//            var convert = new ConvertDensities();
//            var expected = 2m;
//            var actual = convert.ConvertCupsToHalfGallon(16m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToGallon() {
//            var convert = new ConvertDensities();
//            var expected = 1m;
//            var actual = convert.ConvertCupsToGallon(16m);
//            Assert.AreEqual(expected, actual);
//        }
//        [TestMethod]
//        public void ConvertCupsToGallon2() {
//            var convert = new ConvertDensities();
//            var expected = 16m;
//            var actual = convert.ConvertCupsToGallon(256m);
//            Assert.AreEqual(expected, actual);
//        }
//    }
//}