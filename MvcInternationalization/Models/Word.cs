namespace MvcInternationalization.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Word : DbContext
    {
        public Word()
            : base("name=Word")
        {
        }

        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Translate> Translates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>()
                .Property(e => e.Culture)
                .IsUnicode(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Language)
                .IsFixedLength();

            modelBuilder.Entity<Translate>()
                .Property(e => e.Culture)
                .IsUnicode(false);

            modelBuilder.Entity<Translate>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
