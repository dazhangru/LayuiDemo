namespace LayUIDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MallModel : DbContext
    {
        public MallModel()
            : base("name=MallModel1")
        {
        }

        public virtual DbSet<Mall> Mall { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mall>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
