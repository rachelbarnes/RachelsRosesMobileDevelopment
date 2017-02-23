namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IngredientSellingData")]
    public partial class IngredientSellingData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ingredient_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string walmart_name { get; set; }

        public int? walmart_item_id { get; set; }

        [StringLength(50)]
        public string selling_weight { get; set; }

        public decimal? selling_price { get; set; }

        public int? sold_in_packs { get; set; }
    }
}
