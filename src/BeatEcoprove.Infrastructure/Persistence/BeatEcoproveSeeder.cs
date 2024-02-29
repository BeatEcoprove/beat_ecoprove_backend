using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence;

public class BeatEcoproveSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        SeedColors(modelBuilder);
        SeedBrands(modelBuilder);
        SeedServices(modelBuilder);
    }

    private static void SeedServices(ModelBuilder modelBuilder)
    {
        var washServiceId = MaintenanceServiceId.Create(Guid.NewGuid());
        modelBuilder.Entity<MaintenanceService>()
            .HasData(
                new
                {
                    Id = washServiceId,
                    Badge = "public/default/wash.png",
                    Title = "Lavar",
                    Description = "De que forma pretende lavar?"
                }
            );

        modelBuilder.Entity<MaintenanceAction>()
            .HasData(
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "Lavar à mão",
                    Description = "Lavar à mão com água e sabão",
                    Badge = "public/default/wash/hand.png",
                    SustainablePoints = 100,
                    EcoScore = 10
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "A menos de 30ºC",
                    Description = "Lavar a menos de 30ºC",
                    Badge = "public/default/wash/less30.png",
                    SustainablePoints = 2,
                    EcoScore = -1
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "A menos de 50ºC",
                    Description = "Lavar a menos de 50ºC",
                    Badge = "public/default/wash/less50.png",
                    SustainablePoints = 1,
                    EcoScore = -2
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "A menos de 70ºC",
                    Description = "Lavar a menos de 70ºC",
                    Badge = "public/default/wash/less70.png",
                    SustainablePoints = 1,
                    EcoScore = -2
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "A menos de 95ºC",
                    Description = "Lavar a menos de 95ºC",
                    Badge = "public/default/wash/less95.png",
                    SustainablePoints = 1,
                    EcoScore = -2
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "A seco",
                    Description = "Lavar a seco",
                    Badge = "public/default/wash/dry.png",
                    SustainablePoints = 0,
                    EcoScore = -3
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = washServiceId,
                    Title = "Serviço de lavandaria",
                    Description = "Escolhe uma lavandaria",
                    Badge = "public/default/service.png",
                    SustainablePoints = 100,
                    EcoScore = 10
                }
            );

        var dryServiceId = MaintenanceServiceId.Create(Guid.NewGuid());
        modelBuilder.Entity<MaintenanceService>()
            .HasData(
                new
                {
                    Id = dryServiceId,
                    Badge = "public/default/dry.png",
                    Title = "Secar",
                    Description = "De que forma pretende secar?"
                }
            );

        modelBuilder.Entity<MaintenanceAction>()
            .HasData(
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = dryServiceId,
                    Title = "Ao ar livre",
                    Description = "Secar ao ar livre",
                    Badge = "public/default/dry/air.png",
                    SustainablePoints = 2,
                    EcoScore = 0
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = dryServiceId,
                    Title = "Na máquina",
                    Description = "Secar na máquina",
                    Badge = "public/default/dry/machine.png",
                    SustainablePoints = 1,
                    EcoScore = -1
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = dryServiceId,
                    Title = "Serviço de Secagem",
                    Description = "Escolhe um serviço de secagem",
                    Badge = "public/default/service.png",
                    SustainablePoints = 100,
                    EcoScore = 10
                }
            );

        var ironServiceId = MaintenanceServiceId.Create(Guid.NewGuid());
        modelBuilder.Entity<MaintenanceService>()
            .HasData(
                new
                {
                    Id = ironServiceId,
                    Badge = "public/default/iron.png",
                    Title = "Engomar",
                    Description = "De que forma pretende engomar?"
                }
            );

        modelBuilder.Entity<MaintenanceAction>()
            .HasData(
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = ironServiceId,
                    Title = "A menos de 110ºC",
                    Description = "Engomar a menos de 110ºC",
                    Badge = "public/default/iron/less110.png",
                    SustainablePoints = 1,
                    EcoScore = -1
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = ironServiceId,
                    Title = "A menos de 150ºC",
                    Description = "Engomar a menos de 150ºC",
                    Badge = "public/default/iron/less150.png",
                    SustainablePoints = 1,
                    EcoScore = -1
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = ironServiceId,
                    Title = "A menos de 200ºC",
                    Description = "Engomar a menos de 200ºC",
                    Badge = "public/default/iron/less200.png",
                    SustainablePoints = 1,
                    EcoScore = -1
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = ironServiceId,
                    Title = "Serviço de Engomadoria",
                    Description = "Escolhe um serviço de engomadoria",
                    Badge = "public/default/service.png",
                    SustainablePoints = 100,
                    EcoScore = 10
                }
            );

        var repairServiceId = MaintenanceServiceId.Create(Guid.NewGuid());
        modelBuilder.Entity<MaintenanceService>()
            .HasData(
                new
                {
                    Id = repairServiceId,
                    Badge = "public/default/repair.png",
                    Title = "Engomar",
                    Description = "De que forma pretende arranjar a peça?"
                }
            );

        modelBuilder.Entity<MaintenanceAction>()
            .HasData(
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = repairServiceId,
                    Title = "Pelo Próprio",
                    Description = "Arranjar a peça pelo próprio",
                    Badge = "public/default/repair.png",
                    SustainablePoints = 3,
                    EcoScore = 2
                },
                new
                {
                    Id = MaintenanceActionId.Create(Guid.NewGuid()),
                    MaintenanceService = repairServiceId,
                    Title = "Serviço de Reparação",
                    Description = "Escolhe um serviço de Reparação",
                    Badge = "public/default/service.png",
                    SustainablePoints = 100,
                    EcoScore = 10
                }
            );
    }

    private static void SeedColors(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Color>()
            .HasData(
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Black",
                    Hex = "FF000000"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "White",
                    Hex = "FFFFFFFF"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Amarelo",
                    Hex = "FFFFE69F"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Azul Claro",
                    Hex = "FF98B3C8"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Azul Escuro",
                    Hex = "FF29394A"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Amarelo Bebê",
                    Hex = "FFF2E7D4"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Amarelo Claro",
                    Hex = "FFC3A572"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Vermelho Claro",
                    Hex = "FFFF6D6D"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Castanho Claro",
                    Hex = "FF948066"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Castanho",
                    Hex = "FF4A2D16"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Cinzento Claro",
                    Hex = "FF4C4C4C"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Rosa",
                    Hex = "FFBE5967"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Castanho Bebê",
                    Hex = "FF8B5F3C"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Laranja",
                    Hex = "FFF58221"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Roxo Claro",
                    Hex = "FFD2AAC5"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Cinzento Bebê",
                    Hex = "FFC0C0C0"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Rosa Claro",
                    Hex = "FFF9C7C4"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Roxo",
                    Hex = "FFD62598"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Verde",
                    Hex = "FF509C75"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Verde Lima",
                    Hex = "FFC2BC8B"
                },
                new
                {
                    Id = ColorId.Create(Guid.NewGuid()),
                    Name = "Vermelho",
                    Hex = "FFDA252E"
                }
            );
    }

    private static void SeedBrands(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>()
            .HasData(
                new
                {
                    Id = BrandId.Create(Guid.NewGuid()),
                    Name = "Salsa",
                    BrandAvatar = "public/default/brands/salsa.png"
                },
                new
                {
                    Id = BrandId.Create(Guid.NewGuid()),
                    Name = "Losan",
                    BrandAvatar = "public/default/brands/losan.png"
                },
                new
                {
                    Id = BrandId.Create(Guid.NewGuid()),
                    Name = "MO",
                    BrandAvatar = "public/default/brands/mo.png"
                },
                new
                {
                    Id = BrandId.Create(Guid.NewGuid()),
                    Name = "Zippy",
                    BrandAvatar = "public/default/brands/zippy.png"
                }
            );
    }
}