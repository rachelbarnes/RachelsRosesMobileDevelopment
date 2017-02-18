
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class Split {
        //split a string measurement or weight from numbers and the weight
        public string[] SplitMeasurementOrWeightAtSpace(string toSplit) {
            var split = new string[] { };
            for (int i = 0; i < toSplit.Length; i++) {
                if (i > 0 && i < toSplit.Length - 1) {
                    int n;
                    var prevChar = toSplit[i - 1];
                    var currChar = toSplit[i];
                    var nextChar = toSplit[i + 1];
                    if ((int.TryParse(prevChar.ToString(), out n)) && (currChar == ' ') && (!int.TryParse(nextChar.ToString(), out n))) {
                        var splitA = toSplit.Substring(0, i);
                        var splitB = toSplit.Substring(i + 1, toSplit.Length - (i + 1));
                        return split = new string[] { splitA, splitB };
                    }
                }
            }
            return split;
        }
        //split a double level string measurement or density (1 cup 2 tablespoons)
        public string[] SplitDoubleLayerMeasurement(string multiLevelToSplit) {
            var split = new string[] { };
            for (int i = 0; i < multiLevelToSplit.Length; i++) {
                if (i > 0 && i < multiLevelToSplit.Length - 1) {
                    int n;
                    var prevChar = multiLevelToSplit[i - 1];
                    var currChar = multiLevelToSplit[i];
                    var nextChar = multiLevelToSplit[i + 1];
                    if ((!int.TryParse(prevChar.ToString(), out n)) && (currChar == ' ') && (int.TryParse(nextChar.ToString(), out n))) {
                        var firstSplit = multiLevelToSplit.Substring(0, i);
                        var secondSplit = multiLevelToSplit.Substring(i + 1, multiLevelToSplit.Length - (i + 1));
                        return split = new string[] { firstSplit, secondSplit };
                    }
                }
            }
            return split;
        }
        public string[] SplitTripleLayerMeasurement(string multiLevelToSplit) {
            var firstSplitLevelMeasurement = SplitDoubleLayerMeasurement(multiLevelToSplit);
            var fullSplitLevelMeasurement = new string[] { };
            var split = new string[] { };
            for (int i = firstSplitLevelMeasurement[0].Length; i < multiLevelToSplit.Length; i++) {
                if (i > firstSplitLevelMeasurement[0].Length && i < multiLevelToSplit.Length - 1) {
                    int n;
                    var prevChar = multiLevelToSplit[i - 1];
                    var currChar = multiLevelToSplit[i];
                    var nextChar = multiLevelToSplit[i + 1];
                    if ((!int.TryParse(prevChar.ToString(), out n)) && (currChar == ' ') && (int.TryParse(nextChar.ToString(), out n))) {
                        var splitA = SplitDoubleLayerMeasurement(firstSplitLevelMeasurement[1]); 
                        return split = new string[] { firstSplitLevelMeasurement[0], splitA[0], split[1]};
                        //index outside of the bounds of the array
                    }
                }
            }
            return split;
        }
    }
}
