using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RachelBarnesMobileDevelopment;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
namespace RachelsRosesMobileDevelopmentUnitTests {
    [TestClass]
    public class CapitalizeTests {
        [TestMethod]
        public void CapitalizeEveryWord() {
            var capitalize = new Capitalize();
            var expected = "All Purpose Flour";
            var expected2 = "All-Purpose Flour";
            var actual = capitalize.capitalizeFirstLetterOfEachWord("all purpose flour");
            var actual2 = capitalize.capitalizeFirstLetterOfEachWord("all-purpose flour");
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2); 
        }
        [TestMethod]
        public void CapitalizeEveryWord2() {
            var cap = new Capitalize();
            var expected = "Oh The Glory Of The Morning Blossoms";
            var actual = cap.capitalizeFirstLetterOfEachWord("oh the glory of the morning blossoms");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void CapitlizeWordWithNumber() {
            var cap = new Capitalize();
            var expected = "4all purpose flour";
            var actual = cap.capitalizeFirstLetterOfEachWord("4all purpose flour");
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void CapitlizeWordWithSpecialChar() {
            var cap = new Capitalize();
            var ex = "$all purpose flour";
            var actual = cap.capitalizeFirstLetterOfEachWord("$all purpose flour");
            Assert.AreEqual(ex, actual); 
        }
        [TestMethod]
        public void CapitalizeEveryWordInThisSentence() {
            var cap = new Capitalize();
            var ex = "I Wrote Some Code That Will Capitalize The First Letter Of Every Single Word In This Sentence."; 
            var actual = cap.capitalizeFirstLetterOfEachWord("i wrote some code that will capitalize the first letter of every single word in this sentence.");
            Assert.AreEqual(ex, actual); 
        }
        //[TestMethod]
        //public void DoNotCapitalizeOf() {
        //    var cap = new Capitalize();
        //    var ex = "of the a All Purpose if";
        //    var actual = cap.capitalizeFirstLetterOfEachWord("of the a all purpose if");
        //    Assert.AreEqual(ex, actual); 
        //}
    }
}
