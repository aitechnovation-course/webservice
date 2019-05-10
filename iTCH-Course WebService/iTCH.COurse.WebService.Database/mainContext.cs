using System;
using iTCH.COurse.WebService.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace iTCH.COurse.WebService.Database
{
    public partial class mainContext : DbContext
    {
        private readonly string constr;
        private mainContext()
        {
        }

        public mainContext(string _constr)
        {
            constr = _constr;
        }

        public mainContext(DbContextOptions<mainContext> options) : base(options)
        {
        }

        public mainContext(string _constr, DbContextOptions<mainContext> options) : base(options)
        {
            constr = _constr;
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { optionsBuilder.UseSqlServer(constr); }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });
        }
    }
}
