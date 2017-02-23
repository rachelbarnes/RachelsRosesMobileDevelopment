namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recipe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int recipe_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int yield { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal aggregated_price { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal price_per_serving { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int no_of_ingredients { get; set; }
    }
}
