using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

public class CityInfoContext : DbContext
{
    public DbSet<City> Cities { get; set; }

    // DOĞRU isimlendirme
    public DbSet<PointOfInterest> PointsOfInterest { get; set; }

    public CityInfoContext(DbContextOptions<CityInfoContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>()
            .HasData(
                new City("New York City") { Id = 1, Description = "The one with that big park" },
                new City("Antwrep") { Id = 2, Description = "The one with that train station" },
                new City("Paris") { Id = 3, Description = "The one with that tower" });

        modelBuilder.Entity<PointOfInterest>()
            .HasData(
                new PointOfInterest("Central Park") { Id = 1, CityId = 1, Description = "The most visited urban parks" },
                new PointOfInterest("Empire State Building") { Id = 2, CityId = 1, Description = "Big skyscraper" },
                new PointOfInterest("Cathedral") { Id = 3, CityId = 2, Description = "Gothic style cathedral" },
                new PointOfInterest("Antwrep Central Station") { Id = 4, CityId = 2, Description = "Antrwrep biggest station" },
                new PointOfInterest("Eiffel Tower") { Id = 5, CityId = 3, Description = "Big tower" },
                new PointOfInterest("The Louvre") { Id = 6, CityId = 3, Description = "Largest museum" });

        base.OnModelCreating(modelBuilder);
    }
}