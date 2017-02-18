using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class ConvertDensities{
        //ounces conversion calculations
            //1 ounce = 28.3495 grams
            //i ounce = .0625 lbs
        public Func<decimal, decimal> ConvertOuncesToGrams = ounces => Math.Round((ounces * 28.3495m), 2);
        public Func<decimal, decimal> ConvertOuncesToLbs = ounces => Math.Round((ounces / 16), 2);
        //grams conversion calculations
            //1 gram = .00220462 lbs
            //1 gram = .035274 ounces
        public Func<decimal, decimal> ConvertGramsToLbs = grams => Math.Round((grams / 453.592m), 2);
        public Func<decimal, decimal> ConvertGramsToOunces = grams => Math.Round((grams / 28.3495m), 2);
        //lbs conversion calculations
            //1 lb = 16 oz
            //1 lb = 453.592 grams
        public Func<decimal, decimal> ConvertLbsToOunces = lbs => Math.Round((lbs * 16), 2);
        public Func<decimal, decimal> ConvertLbsToGrams = lbs => Math.Round((lbs * 453.592m), 2);
        //gallons conversion calculations
            //1 gallon = 128 oz
            //1 gallon = 2 1/2 gallon
            //1 gallon = 4 quarts
            //1 gallon = 8 pints
            //1 gallon = 16 cups
        public Func<decimal, decimal> ConvertGallonsToOunces = gall => Math.Round((gall * 128), 2);
        public Func<decimal, decimal> ConvertGallonsToHalfGallon = gall => Math.Round((gall * 2), 2); 
        public Func<decimal, decimal> ConvertGallonsToQuarts = gall => Math.Round((gall * 4), 2);
        public Func<decimal, decimal> ConvertGallonsToPints = gall => Math.Round((gall * 8), 2);
        public Func<decimal, decimal> ConvertGallonsToCups = gall => Math.Round((gall * 16), 2);
        //half gallon conversion calculations
        //1 half gallon = 1/2 gallon
        //1/2 gallon = 2 pints
        //1/2 gallon = 4 cups
        public Func<decimal, decimal> ConvertHalfGallonToGallon = half => Math.Round((half / 2), 2);
        public Func<decimal, decimal> ConvertHalfGallonToPint = half => Math.Round((half * 2), 2);
        public Func<decimal, decimal> ConvertHalfGallonToCups = half => Math.Round((half * 4), 2);  
        //pint conversion calculations
            //1 pint = 2 cups
            //1 pint = .125 gallons
            //1 pint = .5 quart
        public Func<decimal, decimal> ConvertPintsToCups = pint => Math.Round((pint * 2), 2);
        public Func<decimal, decimal> ConvertPintsToGallons = pint => Math.Round((pint / 8), 2);
        public Func<decimal, decimal> ConvertPintsToQuarts = pint => Math.Round((pint / 2), 2);
        public Func<decimal, decimal> ConvertPintsToHalfGallons = pint => Math.Round((pint / 4), 2);
        //quart conversion calculations
        //1 quart = 1/4 gallon
        //1 quart = 2 pints
        //1 quart = 4 cups
        public Func<decimal, decimal> ConvertQuartToGallon = q => Math.Round((q / 4), 2);
        public Func<decimal, decimal> ConvertQuartToPints = q => Math.Round((q * 2), 2);
        public Func<decimal, decimal> ConvertQuartToCups = q => Math.Round((q * 4), 2);
        //cups conversion calculations
        //1 cup = 1/2 pint
        //1 cup = 1/4 quart
        //1 cup = 1/8 1/2 gallon
        //1 cup = 1/16 gallon
        public Func<decimal, decimal> ConvertCupsToPints = c => Math.Round((c / 2), 2);
        public Func<decimal, decimal> ConvertCupsToQuarts = c => Math.Round((c / 4), 2);
        public Func<decimal, decimal> ConvertCupsToHalfGallon = c => Math.Round((c / 8), 2);
        public Func<decimal, decimal> ConvertCupsToGallon = c => Math.Round((c / 16), 2);
    }
}