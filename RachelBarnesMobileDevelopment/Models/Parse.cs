
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
                else if (decimalValue == 5 || decimalValue == 50)
                    fraction = "1/2";
                else if (decimalValue == 33)
                    fraction = "1/3";
                else if (decimalValue == 25)
                    fraction = "1/4";
                else if (decimalValue == 12 || decimalValue == 13)
                    fraction = "1/8";
                else if (fraction == "") {
                    fraction = decSplit[1].ToString();
                    properFraction = (wholeNumber == "0") ? string.Format(".{0}", fraction) : string.Format("{0}.{1}", wholeNumber, fraction);
                    return properFraction;
                }
                properFraction = (wholeNumber == "0") ? string.Format("{0}", fraction) : string.Format("{0} {1}", wholeNumber, fraction);
                return properFraction; 
            } else return "Decimal did not parse correctly.";
        }
    }
}