using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public partial class eHousingContext : DbContext
    {
        public eHousingContext(DbContextOptions<eHousingContext> options)
           : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<EstateStatus> EstateStatuses { get; set; }
        public DbSet<EstateType> EstateTypes { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<FavoriteEstate> FavoriteEstates { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteEstate>().HasKey(f => new { f.UserId, f.EstateId });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
