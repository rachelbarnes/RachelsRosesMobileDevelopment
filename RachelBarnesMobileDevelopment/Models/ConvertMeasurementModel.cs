using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class ConvertMeasurementCalculations {
        //aggregate the teaspoons from the entire measurement
        public decimal AggregateTeaspoons(string measurement) {
            var parse = new Parse();
            var convertM = new ConvertMeasurement();
            var split = new Split();
            var splitMeasurement = split.SplitMeasurementOrDensity(measurement);
            var aggregatedTeaspoons = 0m;
            foreach (var meas in splitMeasurement) {
                var splitMeas = split.SplitSingleMeasurementOrDensity(meas);
                var splitMeasDecimal = parse.ParseFractionToDecimal(splitMeas[0]);
                if (meas.Contains("cup") || meas.ToLower().Contains("c"))
                    aggregatedTeaspoons += convertM.ConvertCupsToTeaspoons(splitMeasDecimal);
                else if (meas.Contains("table") || meas.Contains("T"))
                    aggregatedTeaspoons += convertM.ConvertTablespoonsToTeaspoons(splitMeasDecimal);
                else if (meas.Contains("tea") || meas.Contains("t"))
                    aggregatedTeaspoons += splitMeasDecimal;
                else if (meas.Contains("pinch"))
                    aggregatedTeaspoons += convertM.ConvertPinchesToTeaspoons(splitMeasDecimal);
            }
            return aggregatedTeaspoons;
        }
        public decimal Multiplier(decimal changeTo, decimal changeFrom) {
            return changeTo / changeFrom;
        }
        public decimal Multiplier(int changeTo, int changeFrom) {
            return (decimal)changeTo / (decimal)changeFrom;
        }
        public decimal Multiplier(string changeTo, string changeFrom) {
            var parse = new Parse();
            return (parse.ParseFractionToDecimal(changeTo)) / (parse.ParseFractionToDecimal(changeFrom));
        }
        public string MultiplierString(decimal changeTo, decimal changeFrom) {
            var parse = new Parse();
            return parse.ParseDecimalToFraction(Math.Round((changeTo / changeFrom), 2));
        }
        public string MultiplierString(int changeTo, int changeFrom) {
            var parse = new Parse();
            return parse.ParseDecimalToFraction(Math.Round(((decimal)changeTo / (decimal)changeFrom), 2));
        }
        public string MultiplierString(string changeTo, string changeFrom) {
            var parse = new Parse();
            var changeToDecimal = parse.ParseFractionToDecimal(changeTo);
            var changeFromDecimal = parse.ParseFractionToDecimal(changeFrom);
            return parse.ParseDecimalToFraction(Math.Round((changeToDecimal / changeFromDecimal), 2));
        }
        public decimal AdjustedTeaspoons(decimal aggregatedTeaspoons, decimal multiplier) {
            return decimal.Round((aggregatedTeaspoons * multiplier), 2);
        }
        public decimal AdjustedTeaspoons(decimal aggregatedTeaspoons, int multiplier) {
            return decimal.Round((aggregatedTeaspoons * (decimal)multiplier), 2);
        }
        public decimal AdjustedTeaspoons(decimal aggregatedTeaspoons, string multiplier) {
            var parse = new Parse();
            return decimal.Round((aggregatedTeaspoons * (parse.ParseFractionToDecimal(multiplier))), 2);
        }
        public void AddMeasurementToDictionary(Dictionary<string, decimal> dict, string key, decimal value) {
            if (dict.Keys.Contains(key))
                dict[key] = dict[key] + value;
            if (!dict.Keys.Contains(key))
                dict.Add(key, value);
        }
        public string CondenseTeaspoonsToMeasurement(decimal t) {
            var parse = new Parse();
            var measDict = new Dictionary<string, decimal>();
            var condensedMeasurement = "";
            while (t > 0m) {
                if (t >= 576m) {
                    AddMeasurementToDictionary(measDict, "cups", 12m);
                    t -= 576m;
                }
                if (t >= 384m) {
                    AddMeasurementToDictionary(measDict, "cups", 8m);
                    t -= 384m;
                }
                if (t >= 192m) {
                    AddMeasurementToDictionary(measDict, "cups", 4m);
                    t -= 192m;
                }
                if (t >= 96m) {
                    AddMeasurementToDictionary(measDict, "cups", 2m);
                    t -= 96m;
                }
                if (t >= 48m) {
                    AddMeasurementToDictionary(measDict, "cups", 1m);
                    t -= 48m;
                }
                if (t < 48m && t >= 36m) {
                    AddMeasurementToDictionary(measDict, "cups", .75m);
                    t -= 36m;
                }
                if (t < 36m && t >= 32) {
                    AddMeasurementToDictionary(measDict, "cups", .66m);
                    t -= 32;
                }
                if (t < 32m && t >= 24m) {
                    AddMeasurementToDictionary(measDict, "cups", .5m);
                    t -= 24m;
                }
                if (t < 24 && t >= 16) {
                    AddMeasurementToDictionary(measDict, "cups", .33m);
                    t -= 16m;
                }
                if (t < 24m && t >= 12m) {
                    AddMeasurementToDictionary(measDict, "cups", .25m);
                    t -= 12m;
                }
                if (t < 12m && t > 3m) {
                    AddMeasurementToDictionary(measDict, "tablespoons", 1m);
                    t -= 3m;
                }
                if (t < 3m && t >= 1m) {
                    AddMeasurementToDictionary(measDict, "teaspoons", 1m);
                    t -= 1m;
                }
                if (t < 1m && t >= .75m) {
                    AddMeasurementToDictionary(measDict, "teaspoons", .75m);
                    t -= .75m;
                }
                if (t < .75m && t >= .5m) {
                    AddMeasurementToDictionary(measDict, "teaspoons", .5m);
                    t -= .5m;
                }
                if (t < .5m && t >= .25m) {
                    AddMeasurementToDictionary(measDict, "teaspoons", .25m);
                    t -= .25m;
                }
                if (t < .25m && t >= .125m) {
                    AddMeasurementToDictionary(measDict, "teaspoons", .125m);
                    t -= .125m;
                }
                if (t < .125m && t >= .05m) {
                    AddMeasurementToDictionary(measDict, "pinches", 1m);
                    t -= .05m;
                }
                if (t < .05m && t > 0m) {
                    AddMeasurementToDictionary(measDict, "pinches", 1m);
                    t = 0m; 
                }
            }
            foreach (var measurement in measDict) {
                var boolean = measurement.Value == 1m;
                var single = measurement.Key.Substring(0, measurement.Key.Length - 1);
                var singlePinch = measurement.Key.Substring(0, measurement.Key.Length - 2); 
                if (boolean && measurement.Key.Contains("pinch"))
                    condensedMeasurement += string.Format("{0} {1} ", parse.ParseDecimalToFraction(measurement.Value), measurement.Key.Substring(0, (measurement.Key.Length - 2)));
                else if (boolean)
                    condensedMeasurement += string.Format("{0} {1} ", parse.ParseDecimalToFraction(measurement.Value), measurement.Key.Substring(0, (measurement.Key.Length - 1)));
                else
                    condensedMeasurement += string.Format("{0} {1} ", parse.ParseDecimalToFraction(measurement.Value), measurement.Key);
                //condensedMeasurement += (measurement.Value == 1m) ? string.Format("{0} {1} ", parse.ParseDecimalToFraction(measurement.Value), measurement.Key.Substring(0, (measurement.Key.Length - 1))) : string.Format("{0} {1} ", parse.ParseDecimalToFraction(measurement.Value), measurement.Key);
            }
            return condensedMeasurement.Trim();
        }
        public string AdjustMeasurement(string measurement, decimal changeTo, decimal changeFrom) {
            var multiplier = Multiplier(changeTo, changeFrom);
            var adjustment = AdjustedTeaspoons(AggregateTeaspoons(measurement), multiplier);
            return CondenseTeaspoonsToMeasurement(adjustment); 
        }
    }
}