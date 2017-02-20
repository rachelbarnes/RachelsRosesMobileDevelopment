using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopmentTests {
    [TestClass]
    public class ParseTests {
        [TestMethod]
        public void TestParseFractionToDecimal() {
            var parse = new Parse();
            var expected = 1.5m;
            var actual = parse.ParseFractionToDecimal("1 1/2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseFractionToDecimal2() {
            var parse = new Parse();
            var expected = 3.125m;
            var actual = parse.ParseFractionToDecimal("3 1/8");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseFractionToDecimal3() {
            var parse = new Parse();
            var expected = 3m;
            var actual = parse.ParseFractionToDecimal("3");
            Assert.AreEqual(expected, actual);
        }
        //convert decimal to fraction
        [TestMethod]
        public void TestParseDecimalToFraction() {
            var parse = new Parse();
            var expected = "1";
            var actual = parse.ParseDecimalToFraction(1m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction2() {
            var parse = new Parse();
            var expected = "1/2";
            var actual = parse.ParseDecimalToFraction(.5m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction3() {
            var parse = new Parse();
            var expected = "7/8";
            var actual = parse.ParseDecimalToFraction(.87m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction4() {
            var parse = new Parse();
            var expected = "2/3";
            var actual = parse.ParseDecimalToFraction(.66m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction5() {
            var parse = new Parse();
            var expected = "3/4";
            var actual = parse.ParseDecimalToFraction(.75m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction6() {
            var parse = new Parse();
            var expected = "1/3";
            var actual = parse.ParseDecimalToFraction(.33m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction7() {
            var parse = new Parse();
            var expected = "1/4";
            var actual = parse.ParseDecimalToFraction(.25m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction8() {
            var parse = new Parse();
            var expected = "1/8";
            var actual = parse.ParseDecimalToFraction(.12m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction9() {
            var parse = new Parse();
            var expected = "1.95";
            var actual = parse.ParseDecimalToFraction(1.95m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction10() {
            var parse = new Parse();
            var expected = "1 1/2";
            var actual = parse.ParseDecimalToFraction(1.5m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction11() {
            var parse = new Parse();
            var expected = "1 1/3";
            var actual = parse.ParseDecimalToFraction(1.33m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction12() {
            var parse = new Parse();
            var expected = "12 7/8";
            var actual = parse.ParseDecimalToFraction(12.87m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParseDecimalToFraction13() {
            var parse = new Parse();
            var expected = "6 3/4";
            var actual = parse.ParseDecimalToFraction(6.75m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEvenNumberFalse() {
            var parse = new Parse();
            var expected = false;
            var actual = parse.isDecimalEven(1m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEvenNumberTrue() {
            var parse = new Parse();
            var expected = true;
            var actual = parse.isDecimalEven(2m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEvenNumberFalse2() {
            var parse = new Parse();
            var expected = false;
            var actual = parse.isDecimalEven(1.33m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEvenNumberTrue2() {
            var parse = new Parse();
            var expected = true;
            var actual = parse.isDecimalEven(2.50m);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEvenNumberFalse3() {
            var parse = new Parse();
            var expected = false;
            var actual = parse.isDecimalEven(55.55m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestEvenNumberTrue3() {
            var parse = new Parse();
            var expected = true;
            var actual = parse.isDecimalEven(55.56m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondenseDecimalToFraction() {
            var parse = new Parse();
            var expected = "25/50";
            var actual = parse.CondenseDecimalToFraction(.50m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondeseDecimalToFraction2() {
            var parse = new Parse();
            var expected = "14/28";
            var actual = parse.CondenseDecimalToFraction(.28m);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCondenseDecimalToFraction3() {
            var parse = new Parse();
            var expected = "1 25/50";
            var actual = parse.CondenseDecimalToFraction(1.50m);
            Assert.AreEqual(expected, actual); 
        }
    }
}
