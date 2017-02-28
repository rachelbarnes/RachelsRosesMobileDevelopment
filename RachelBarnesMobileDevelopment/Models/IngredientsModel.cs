
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class Ingredient {
        int id = 0;
        string name = "";
        string measurement = "";
        string type = "";
        string classification = "";
        decimal density = 0m;
        decimal sellingPrice = 0m;
        string sellingWeight = "";
        decimal sellingWeightInOunces = 0m;
        int walmartId = 0;
        string walmartName = "";
        bool doesIngredientNeedRestocking = false;
        bool isIngredientSoldInAPack = false;
        public Ingredient() { }
        public Ingredient(string name, string measurement) {
            var _id = this.id;
            var _name = name;
            var _measurement = this.measurement;
            var _type = this.type;
            var _classification = this.classification;
            var _density = this.density;
            var _sellingPrice = this.sellingPrice;
            var _sellingWeight = this.sellingWeight;
            var _sellingWeightInOunces = this.sellingWeightInOunces;
            var _walmartId = this.walmartId;
            var _walmartName = this.walmartName;
            var _doesIngredientNeedRestocking = this.doesIngredientNeedRestocking;
            var _isIngredientSoldInAPack = this.isIngredientSoldInAPack;
        }
        public Ingredient(int id) {
            var _id = this.id;
            var _name = name;
            var _measurement = this.measurement;
            var _type = this.type;
            var _classification = this.classification;
            var _density = this.density;
            var _sellingPrice = this.sellingPrice;
            var _sellingWeight = this.sellingWeight;
            var _sellingWeightInOunces = this.sellingWeightInOunces;
            var _walmartId = this.walmartId;
            var _walmartName = this.walmartName;
            var _doesIngredientNeedRestocking = this.doesIngredientNeedRestocking;
            var _isIngredientSoldInAPack = this.isIngredientSoldInAPack;
        }
    }
}