using BeatEcoprove.Domain.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence;

public class BeatEcoproveSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        // SeedColors(modelBuilder);
        // SeedBrands(modelBuilder);
    }

    private static void SeedColors(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Color>()
            .HasData(
                Color.Create("Black", "FF000000"),
                Color.Create("White", "FFFFFFFF"),
                Color.Create("Red", "FFFF0000"),
                Color.Create("Blue", "FF0000FF"),
                Color.Create("Green", "FF00FF00")
            );
    }
    
    private static void SeedBrands(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>()
            .HasData(
                Brand.Create("Salsa", "..."),
                Brand.Create("MO", "..."),
                Brand.Create("Tifosi", "...")
            );
    }
}