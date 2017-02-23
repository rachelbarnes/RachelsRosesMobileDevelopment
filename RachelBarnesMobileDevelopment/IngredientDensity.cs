namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IngredientDensity
    {
        [StringLength(100)]
        public string ingredient_type { get; set; }

        [Key]
        public decimal density { get; set; }
    }
}
