namespace RachelBarnesMobileDevelopment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyPantry")]
    public partial class MyPantry
    {
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(250)]
        public string walmart_name { get; set; }

        public int? walmart_item_id { get; set; }

        public decimal? ounces_consumed_of_product { get; set; }

        public decimal? ounces_remaining_of_product { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime expiration_date { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int refill_needed { get; set; }
    }
}
