using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.PlacesMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.PlacesMicroservice.Database.Contexts
{
    public class PlacesContext : RelationalCoreContext
    {
        public PlacesContext(IEntityFrameworkCoreDatabaseBuilder builder) : base(builder)
        {
        }

        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<ProvinceEntity> Provinces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.AutoModelCreating(modelBuilder);

            modelBuilder.Entity<CountryEntity>(model =>
            {
                model.HasIndex(x => x.ShortName);
            });

            modelBuilder.Entity<CityEntity>(model =>
            {
                model.HasIndex(x => x.Code);
            });
        }
    }
}