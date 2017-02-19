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
            }
            return aggregatedTeaspoons;
        }
        //public Func<decimal, decimal, decimal> Multiplier = (changeTo, changeFrom) => changeTo / changeFrom;
        //public Func<int, int, decimal> Multiplier = (changeTo, changeFrom) => changeTo / changeFrom; 
        
        public decimal Multiplier(decimal changeTo, decimal changeFrom) {
            return changeTo / changeFrom; 
        }
        public decimal Multiplier(int changeTo, int changeFrom) {
            return (decimal)changeTo/ (decimal)changeFrom; 
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
    }
}