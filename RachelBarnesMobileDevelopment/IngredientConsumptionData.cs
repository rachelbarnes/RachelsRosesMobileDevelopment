namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IngredientConsumptionData")]
    public partial class IngredientConsumptionData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ingredient_id { get; set; }

        [StringLength(100)]
        public string measurement { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public decimal? ounces_consumed { get; set; }

        public decimal? ounces_remaining_at_time_of_use { get; set; }
    }
}
