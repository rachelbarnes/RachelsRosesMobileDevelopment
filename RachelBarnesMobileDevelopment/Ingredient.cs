namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredient
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ingredient_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(70)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(70)]
        public string measurement { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string type { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string classification { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string selling_weight { get; set; }

        public int? recipe_id { get; set; }
    }
}
