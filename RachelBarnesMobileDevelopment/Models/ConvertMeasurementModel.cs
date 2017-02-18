using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class ConvertMeasurement {
        //teaspoon calculations: 
        public Func<decimal, decimal> ConvertTeaspoonsToTablespoons = teaspoons => Math.Round((teaspoons / 3), 2);
        public Func<decimal, decimal> ConvertTeaspoonsToCups = teaspoons => Math.Round((teaspoons / 48), 2);
        //tablespoon calculations: 
            //for converting .33m tablespoons to teaspoons, i'm getting .99m, which makes sense but is not desirable... i want to be able to round up to a whole number
                //maybe do some ?? bools for this? 
        public Func<decimal, decimal> ConvertTablespoonsToTeaspoons = tablespoons => Math.Round((tablespoons * 3), 2);
        public Func<decimal, decimal> ConvertTablespoonsToCups = tablespoons => Math.Round((tablespoons / 16), 2);
        //cup calculations: 
        public Func<decimal, decimal> ConvertCupsToTeaspoons = cups => Math.Round((cups * 48), 2);
        public Func<decimal, decimal> ConvertCupsToTablespoons = cups => Math.Round((cups * 16), 2); 
    }
}