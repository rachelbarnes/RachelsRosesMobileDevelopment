namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ingredient_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(250)]
        public string walmart_name { get; set; }

        public int? walmart_item_id { get; set; }

        [StringLength(50)]
        public string selling_weight { get; set; }

        public decimal? selling_weight_in_ounces { get; set; }

        public decimal? price_per_ounce { get; set; }
    }
}
