namespace Exercise_7_Cars
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarModel : DbContext
    {
        public CarModel()
            : base("name=CarModel")
        {
        }

        public virtual DbSet<CarsTable> CarsTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarsTable>()
                .Property(e => e.brand)
                .IsUnicode(false);

            modelBuilder.Entity<CarsTable>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<CarsTable>()
                .Property(e => e.color)
                .IsUnicode(false);
        }
    }
}
