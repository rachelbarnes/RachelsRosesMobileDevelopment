using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RachelBarnesMobileDevelopment;
using RachelBarnesMobileDevelopment.Models;
namespace RachelBarnesMobileDevelopment {
    public class ConvertWeightToOunces {
        public string[] SplitWeight(string weight) {
            int n;
            var splitWeightFinal = new string[] { };
            for (int i = 0; i < weight.Length; i++) {
                if (i > 0 && i < (weight.Length - 1)) {
                    var prev = weight[i - 1];
                    var curr = weight[i];
                    var next = weight[i + 1];
                    if ((int.TryParse(prev.ToString(), out n) && (curr == ' ') && (int.TryParse(next.ToString(), out n) == false))) {
                        var numericalPortionOfWeight = weight.Substring(0, i);
                        var stringPortionOfWeight = weight.Substring((i + 1), (weight.Length - 1));
                        return splitWeightFinal = new string[] { numericalPortionOfWeight, stringPortionOfWeight };
                    }
                }
            }
            return splitWeightFinal;
        }
    }
}