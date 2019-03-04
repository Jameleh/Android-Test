namespace MvcInternationalization.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MvcInternationalization : DbContext
    {
        public MvcInternationalization()
            : base("name=MvcInternationalization2")
        {
        }

        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Translate> Translates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>()
                .Property(e => e.Culture)
                .IsUnicode(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Translate>()
                .Property(e => e.Culture)
                .IsUnicode(false);

            modelBuilder.Entity<Translate>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
