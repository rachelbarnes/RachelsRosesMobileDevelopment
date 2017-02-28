
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class Split {
        //split a string measurement or weight from numbers and the weight
        public string[] SplitSingleMeasurementOrDensity(string toSplit) {
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
        public string[] SplitDoubleLayerMeasurement(string multiLevelMeasurement) {
            var split = new string[] { };
            for (int i = 0; i < multiLevelMeasurement.Length; i++) {
                if (i > 0 && i < multiLevelMeasurement.Length - 1) {
                    int n;
                    var prevChar = multiLevelMeasurement[i - 1];
                    var currChar = multiLevelMeasurement[i];
                    var nextChar = multiLevelMeasurement[i + 1];
                    if ((!int.TryParse(prevChar.ToString(), out n)) && (currChar == ' ') && (int.TryParse(nextChar.ToString(), out n))) {
                        var firstSplit = multiLevelMeasurement.Substring(0, i);
                        var secondSplit = multiLevelMeasurement.Substring(i + 1, multiLevelMeasurement.Length - (i + 1));
                        return split = new string[] { firstSplit, secondSplit };
                    }
                }
            }
            return split;
        }
        public string[] SplitTripleLayerMeasurement(string multiLevelMeasurement) {
            var firstSplitLevelMeasurement = SplitDoubleLayerMeasurement(multiLevelMeasurement);
            var fullSplitLevelMeasurement = new string[] { };
            var split = new string[] { };
            for (int i = firstSplitLevelMeasurement[0].Length; i < multiLevelMeasurement.Length; i++) {
                if (i > firstSplitLevelMeasurement[0].Length && i < multiLevelMeasurement.Length - 1) {
                    int n;
                    var prevChar = multiLevelMeasurement[i - 1];
                    var currChar = multiLevelMeasurement[i];
                    var nextChar = multiLevelMeasurement[i + 1];
                    if ((!int.TryParse(prevChar.ToString(), out n)) && (currChar == ' ') && (int.TryParse(nextChar.ToString(), out n))) {
                        var splitA = SplitDoubleLayerMeasurement(firstSplitLevelMeasurement[1]);
                        return split = new string[] { firstSplitLevelMeasurement[0], splitA[0], splitA[1] };
                    }
                }
            }
            return split;
        }
        public string[] SplitQuadLayerMeasurement(string multiLevelMeasurement) {
            var firstSplitLevelMeasurement = SplitDoubleLayerMeasurement(multiLevelMeasurement);
            var secondSplitLevelMeasurement = SplitTripleLayerMeasurement(firstSplitLevelMeasurement[1]);
            var split = new string[] { };
            for (int i = (firstSplitLevelMeasurement[0].Length + secondSplitLevelMeasurement[0].Length); i < multiLevelMeasurement.Length; i++) {
                if (i > (firstSplitLevelMeasurement[0].Length + secondSplitLevelMeasurement[0].Length) && i < multiLevelMeasurement.Length - 1) {
                    int n;
                    var prevChar = multiLevelMeasurement[i - 1];
                    var currChar = multiLevelMeasurement[i];
                    var nextChar = multiLevelMeasurement[i + 1];
                    if ((!int.TryParse(prevChar.ToString(), out n)) && (currChar == ' ') && (int.TryParse(nextChar.ToString(), out n))) {
                        return split = new string[] { firstSplitLevelMeasurement[0], secondSplitLevelMeasurement[0], secondSplitLevelMeasurement[1], secondSplitLevelMeasurement[2] };
                    }
                }
            }
            return split;
        }
        public string[] SplitMeasurementOrDensity(string measurementToBeSplit) {
            //i have " c ", etc. with spaces to distinguish them from the teaspoons, tablespoons and cups when doing the parsing; 
                //i don't want to get extra in my count
            var measurements = new string[] { "cup", "pinch", "gram", "tea", "table" };
            var split = new string[] { };
            var count = 0;
            foreach (var meas in measurements) {
                if (measurementToBeSplit.Contains(meas))
                    count++;
            }
            if (count == 1)
                return split = new string[] { measurementToBeSplit };
            else if (count == 2)
                return split = SplitDoubleLayerMeasurement(measurementToBeSplit);
            else if (count == 3)
                return split = SplitTripleLayerMeasurement(measurementToBeSplit);
            else if (count == 4)
                return split = SplitQuadLayerMeasurement(measurementToBeSplit);
            return split;
        }
    }
}