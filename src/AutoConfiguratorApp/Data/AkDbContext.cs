using AutoConfiguratorApp.Migrations;
using AutoConfiguratorApp.Models;
using AutoConfiguratorApp.Models.Auto;
using AutoConfiguratorApp.Models.SonderAusstattungen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoConfiguratorApp.Data

{
    public class AkDbContext : DbContext
    {
        public AkDbContext(DbContextOptions<AkDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql("Host=localhost;Port=5432;Database=AutoConfDB;Username=postgres;Password=!Kbn1988;Pooling=true;")
                .ReplaceService<IMigrationsSqlGenerator , CustomNpgsqlMigrationsSqlGenerator>();
        }
        public DbSet<Hersteller> Hersteller { get; set; }
        public DbSet<AutoModell> AutoModellen { get; set; }
        public DbSet<Felge> Felgen { get; set; }
        public DbSet<Lackierung> Lackierungen { get; set; }
        public DbSet<Motor> Motoren { get; set; }
        public DbSet<FahrSicherheitsSystem> FahrSicherheitsSysteme { get; set; }
        public DbSet<KlimaAnlage> KlimaAnlagen { get; set; }
        public DbSet<NavigationsSystem> NavigationsSysteme { get; set; }
        public DbSet<ParkAssistentSystem> ParkAssistentSysteme { get; set; }
        public DbSet<SoundSystem> SoundSysteme { get; set; }
        public DbSet<AutoKonfiguration> AutoKonfigurationen { get; set; }

        // Join tables
        public DbSet<AutoModell_Felge> AutoModelle_Felgen { get; set; }
        public DbSet<AutoModell_Lackierung> AutoModelle_Lackierungen { get; set; }
        public DbSet<AutoModell_Motor> AutoModelle_Motoren { get; set; }

        // Data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hersteller>().HasData(
                new Hersteller { HerstellerId = 100, Name = "LandRover" },
                new Hersteller { HerstellerId = 101, Name = "Porsche" },
                new Hersteller { HerstellerId = 102, Name = "Tesla" },
                new Hersteller { HerstellerId = 103, Name = "AUDI" },
                new Hersteller { HerstellerId = 104, Name = "MercedesBenz" },
                new Hersteller { HerstellerId = 105, Name = "BMW" },
                new Hersteller { HerstellerId = 106, Name = "VW" }
            );
            modelBuilder.Entity<AutoModell>().HasData(
                new AutoModell { AutoModellId = 200, Hersteller_RefId = 100, ModelName = "RangeRover" },
                new AutoModell { AutoModellId = 201, Hersteller_RefId = 100, ModelName = "RangeRover Sport" },
                new AutoModell { AutoModellId = 202, Hersteller_RefId = 100, ModelName = "RangeRover Velar" },
                new AutoModell { AutoModellId = 203, Hersteller_RefId = 101, ModelName = "911" },
                new AutoModell { AutoModellId = 204, Hersteller_RefId = 101, ModelName = "Cayenne" },
                new AutoModell { AutoModellId = 205, Hersteller_RefId = 101, ModelName = "Macan" },
                new AutoModell { AutoModellId = 206, Hersteller_RefId = 102, ModelName = "Model X" },
                new AutoModell { AutoModellId = 207, Hersteller_RefId = 102, ModelName = "Model S" },
                new AutoModell { AutoModellId = 208, Hersteller_RefId = 102, ModelName = "Model 3" },
                new AutoModell { AutoModellId = 209, Hersteller_RefId = 103, ModelName = "RSQ8" },
                new AutoModell { AutoModellId = 210, Hersteller_RefId = 103, ModelName = "R8" },
                new AutoModell { AutoModellId = 211, Hersteller_RefId = 103, ModelName = "RS7" },
                new AutoModell { AutoModellId = 212, Hersteller_RefId = 104, ModelName = "AMG GT" },
                new AutoModell { AutoModellId = 213, Hersteller_RefId = 104, ModelName = "GLE" },
                new AutoModell { AutoModellId = 214, Hersteller_RefId = 104, ModelName = "G-Klasse" },
                new AutoModell { AutoModellId = 215, Hersteller_RefId = 105, ModelName = "8er" },
                new AutoModell { AutoModellId = 216, Hersteller_RefId = 105, ModelName = "X6" },
                new AutoModell { AutoModellId = 217, Hersteller_RefId = 105, ModelName = "7er" }
            );
            
            modelBuilder.Entity<Felge>().HasData(
                new Felge { FelgeId = 300, Size = 18 },
                new Felge { FelgeId = 301, Size = 19 },
                new Felge { FelgeId = 302, Size = 20 },
                new Felge { FelgeId = 303, Size = 21 },
                new Felge { FelgeId = 304, Size = 22 }
            );

        }
    }
}

