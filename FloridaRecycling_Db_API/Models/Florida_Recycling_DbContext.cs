using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FloridaRecycling_Db_API.Models
{
    public partial class Florida_Recycling_DbContext : DbContext
    {
        public DbSet<Metals> Metals { get; set; }

        public Florida_Recycling_DbContext(DbContextOptions options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Metals>(entity =>
            {
                entity.HasKey(e => e.CommodityId)
                    .HasName("PK_Metals");

                //entity.Property(e => e.CommodityImage).HasColumnType("image");
            });
        }
    }
}