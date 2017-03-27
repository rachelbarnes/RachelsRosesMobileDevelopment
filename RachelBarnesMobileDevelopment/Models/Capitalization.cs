using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RachelBarnesMobileDevelopment {
    public class Capitalize {
        public string capitalizeFirstLetterOfEachWord(string ingredientName) {
            var splitIngredientName = new string[] { };
            var splitIngredientNamePartial = new string[] { };
            var finalIngredientName = "";
            int n;
            if (string.IsNullOrEmpty(ingredientName)) 
                return finalIngredientName; 
            if (int.TryParse(ingredientName[0].ToString(), out n))
                return ingredientName;
            if (!char.IsLetterOrDigit(ingredientName[0]))
                return ingredientName; 
            if (ingredientName.Contains(' ')) {
                splitIngredientName = ingredientName.Split(' ');
            }
            foreach (var word in splitIngredientName) {
                var firstLetter = ' ';
                var secondFirstLetter = ' '; //for split words only
                if (word.Contains('-')) {
                    splitIngredientNamePartial = word.Split('-');
                    firstLetter = splitIngredientNamePartial[0][0];
                    secondFirstLetter = splitIngredientNamePartial[1][0];
                    finalIngredientName += string.Format("{0}{1}-{2}{3}",
                                        char.ToUpper(firstLetter), splitIngredientNamePartial[0].Substring(1),
                                        char.ToUpper(secondFirstLetter), splitIngredientNamePartial[1].Substring(1)) + " "; 
                }
                else if (word.ToCharArray().Count() == 1) {
                    firstLetter = word[0];
                    finalIngredientName += char.ToUpper(firstLetter) + " ";
                } else {
                    firstLetter = word[0];
                    finalIngredientName += string.Format("{0}{1}", char.ToUpper(firstLetter), word.Substring(1)) + " ";
                }
                
            }
            return finalIngredientName.Trim();
        }
    }
}