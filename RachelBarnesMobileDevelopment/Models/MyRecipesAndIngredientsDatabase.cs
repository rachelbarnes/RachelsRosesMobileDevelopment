namespace RachelBarnesMobileDevelopment {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyRecipesAndIngredientsDatabaseContext : DbContext {
        public MyRecipesAndIngredientsDatabaseContext()
            : base("name=MyRecipesAndIngredientsDatabase") {
        }

        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<IngredientConsumptionData> IngredientConsumptionDatas { get; set; }
        public virtual DbSet<IngredientDensity> IngredientDensities { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<IngredientSellingData> IngredientSellingDatas { get; set; }
        public virtual DbSet<MyPantry> MyPantries { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Cost>()
                .Property(e => e.selling_weight_in_ounces)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Cost>()
                .Property(e => e.price_per_ounce)
                .HasPrecision(5, 2);

            modelBuilder.Entity<IngredientConsumptionData>()
                .Property(e => e.ounces_consumed)
                .HasPrecision(6, 2);

            modelBuilder.Entity<IngredientConsumptionData>()
                .Property(e => e.ounces_remaining_at_time_of_use)
                .HasPrecision(6, 2);

            modelBuilder.Entity<IngredientDensity>()
                .Property(e => e.density)
                .HasPrecision(4, 2);

            modelBuilder.Entity<IngredientSellingData>()
                .Property(e => e.selling_price)
                .HasPrecision(6, 2);

            modelBuilder.Entity<MyPantry>()
                .Property(e => e.ounces_consumed_of_product)
                .HasPrecision(7, 2);

            modelBuilder.Entity<MyPantry>()
                .Property(e => e.ounces_remaining_of_product)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.aggregated_price)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.price_per_serving)
                .HasPrecision(5, 2);
        }
    }
}
