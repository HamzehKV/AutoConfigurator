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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hersteller>().HasData(
                new Hersteller { HerstellerId = 100, Name = "LandRover" },
                new Hersteller { HerstellerId = 101, Name = "Porsche" },
                new Hersteller { HerstellerId = 102, Name = "AUDI" },
                new Hersteller { HerstellerId = 103, Name = "MercedesBenz" },
                new Hersteller { HerstellerId = 104, Name = "BMW" },
                new Hersteller { HerstellerId = 105, Name = "VW" }
            );
            modelBuilder.Entity<AutoModell>().HasData(
                new AutoModell { AutoModellId = 200, HerstellerRefId = 100, ModelName = "RangeRover" },
                new AutoModell { AutoModellId = 201, HerstellerRefId = 100, ModelName = "RangeRover Sport" },
                new AutoModell { AutoModellId = 202, HerstellerRefId = 100, ModelName = "RangeRover Velar" },
                new AutoModell { AutoModellId = 203, HerstellerRefId = 101, ModelName = "911" },
                new AutoModell { AutoModellId = 204, HerstellerRefId = 101, ModelName = "Cayenne" },
                new AutoModell { AutoModellId = 205, HerstellerRefId = 101, ModelName = "Macan" },
                new AutoModell { AutoModellId = 206, HerstellerRefId = 102, ModelName = "RSQ8" },
                new AutoModell { AutoModellId = 207, HerstellerRefId = 102, ModelName = "R8" },
                new AutoModell { AutoModellId = 208, HerstellerRefId = 102, ModelName = "RS7" },
                new AutoModell { AutoModellId = 209, HerstellerRefId = 103, ModelName = "AMG GT" },
                new AutoModell { AutoModellId = 210, HerstellerRefId = 103, ModelName = "GLE" },
                new AutoModell { AutoModellId = 211, HerstellerRefId = 103, ModelName = "G-Klasse" },
                new AutoModell { AutoModellId = 212, HerstellerRefId = 104, ModelName = "8er" },
                new AutoModell { AutoModellId = 213, HerstellerRefId = 104, ModelName = "X6" },
                new AutoModell { AutoModellId = 214, HerstellerRefId = 104, ModelName = "7er" }
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

