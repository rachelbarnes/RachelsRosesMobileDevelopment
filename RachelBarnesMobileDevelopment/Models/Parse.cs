
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class Parse {
        //parse a fraction to a decimal
        public decimal ParseFractionToDecimal(string fraction) {
            var fractionSplit = fraction.Split(' ');
            var wholeNumber = int.Parse(fractionSplit[0]);
            if (fraction.Contains('/')) {
                var properFraction = fractionSplit[1].Split('/');
                var properFractionDecimal = Decimal.Round((decimal.Parse(properFraction[0]) / decimal.Parse(properFraction[1])), 3);
                return (decimal)wholeNumber + properFractionDecimal;
            }
            return (decimal)wholeNumber;
        }
        //parse a decimal to a fraction
        //start with .5
        public string ParseDecimalToFraction(decimal dec) {
            if (!dec.ToString().Contains('.')) {
                return dec.ToString();
            }
            if (dec.ToString().Contains('.')) {
                var properFraction = "";
                var decSplit = dec.ToString().Split('.');
                var wholeNumber = decSplit[0];
                string fraction = "";
                var decimalValue = int.Parse(decSplit[1]);
                if (decimalValue == 87 || decimalValue == 88)
                    fraction = "7/8";
                else if (decimalValue == 75 || decimalValue == 75)
                    fraction = "3/4";
                else if (decimalValue == 66 || decimalValue == 67)
                    fraction = "2/3";
                //else if (decimalValue == 625)
                //    fraction = "5/8";
                else if (decimalValue == 5 || decimalValue == 50)
                    fraction = "1/2";
                else if (decimalValue == 33)
                    fraction = "1/3";
                else if (decimalValue == 25)
                    fraction = "1/4";
                else if (decimalValue == 12 || decimalValue == 13)
                    fraction = "1/8";
                //this is if the fraction is empty because the decimal is one that is has a hardcoded condition here.
                //while i would like to create an algorithm to filter through this decimal and get a fraction from it, 3/32 is not a fraction I want showing up in one of my conversions
                //i don't want to do that to people; it's better to just give the decimal so there's a better reference point on what needs to be done unfortunately unless I can give the closes fraction to that 3/32 and give the decimal difference between what 3/32 = and what the fraction is (4/32 (1/8) - 3/32 = .03)... i like it!!
                if (fraction == "" && int.Parse(wholeNumber) == 0) {
                    fraction = decSplit[1].ToString();
                    return string.Format(".{0}", fraction);
                } else if (fraction == "" && int.Parse(wholeNumber) != 0)
                    return string.Format("{0}", wholeNumber);
                else
                    properFraction = (wholeNumber == "0") ? string.Format("{0}", fraction) : string.Format("{0} {1}", wholeNumber, fraction);
                return properFraction;
            } else return "Decimal did not parse correctly.";
        }
        public decimal GetDifferenceBetweenHardcodedFractionAndReturnedFraction(string hardcoded, string returned) {
            return decimal.Round((ParseFractionToDecimal(hardcoded) - ParseFractionToDecimal(returned)), 2);
        }
        //5.5, 5.25, 6.33
        //if ((((int.Parse(decimalPortionReturnedDecimalArray[1])) / 2).ToString().Contains('.')))
        //if the int.parse of the decimal part of returnedDecimal has a decimal when it's divded by 2 (so if it's uneven), then return false; otherwise, return true
        //var evenArray = (((int.Parse(decimalPortionReturnedDecimal)) / 2).ToString().Contains('.')) ? false : true;
        public bool isDecimalEven(decimal returnedDecimal) {
            var hardcodedFractions = new string[] { "1/8", "1/3", "1/4", "1/2", "2/3", "3/4", "7/8" };
            var returnedFraction = ParseDecimalToFraction(returnedDecimal);
            var decString = "";
            var decimalPortionReturnedDecimalArray = new string[] { };
            if (returnedDecimal.ToString().Contains('.')) {
                decimalPortionReturnedDecimalArray = returnedDecimal.ToString().Split('.');
                decString = decimalPortionReturnedDecimalArray[1];
            } else decString = returnedDecimal.ToString();
            //if the int.parse(decString) / 2 does NOT has a . (meaning it doesn't divide by 2 cleanly), then return true; 
            var even = !(((decimal.Parse(decString)) / 2).ToString().Contains('.')) ? true : false;
            return even;
        }
        public string CondenseDecimalToFraction(decimal returnedDecimal) {
            var amIEven = isDecimalEven(returnedDecimal);
            var condensedDecimalFraction = "";
            if (amIEven) {
                var decStringArray = new string[] { };
                var decStringWholeNumber = "";
                var decString = "";
                if (returnedDecimal.ToString().Contains('.')) {
                    decStringArray = returnedDecimal.ToString().Split('.');
                    decString = decStringArray[1];
                    decStringWholeNumber = decStringArray[0]; 
                } else decString = returnedDecimal.ToString();
                condensedDecimalFraction = decStringWholeNumber != "0" ? string.Format("{0} {1}/{2}", decStringArray[0], ((decimal.Parse(decString) / 2)), decString) : string.Format("{0}/{1}", ((decimal.Parse(decString) / 2)), decString);
                //var decString = returnedDecimal.ToString().Contains('.') ? returnedDecimal.ToString().Split('.') : returnedDecimal.ToString().ToArray(); 
                var calculatedDecimalFromCondensedFraction = ((decimal.Parse(decStringArray[1])) / 2) / decimal.Parse(decString);
                var continuedEvenness = (isDecimalEven(calculatedDecimalFromCondensedFraction)) ? true : false;
                //i'm trying to find the best way to narrow down the denominator and the numerator with an automated process... 
            }
            return condensedDecimalFraction;
        }
    }
}