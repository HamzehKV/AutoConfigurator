using AutoConfiguratorApp.Migrations;
using AutoConfiguratorApp.Models;
using AutoConfiguratorApp.Models.Auto;
using AutoConfiguratorApp.Models.SonderAusstattungen;
//using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;

namespace AutoConfiguratorApp.Data

{
    public partial class AkDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public AkDbContext(DbContextOptions<AkDbContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder
                    .UseNpgsql(_config.GetConnectionString("PostgreSqlConnection"))
                    .ReplaceService<IMigrationsSqlGenerator, CustomNpgsqlMigrationsSqlGenerator>();
            //}
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
            #region Herteller
            modelBuilder.Entity<Hersteller>().HasData(
                new Hersteller { HerstellerId = 100, Name = "LandRover" },
                new Hersteller { HerstellerId = 101, Name = "Porsche" },
                new Hersteller { HerstellerId = 102, Name = "Tesla" },
                new Hersteller { HerstellerId = 103, Name = "AUDI" },
                new Hersteller { HerstellerId = 104, Name = "MercedesBenz" },
                new Hersteller { HerstellerId = 105, Name = "BMW" },
                new Hersteller { HerstellerId = 106, Name = "VW" }
            );
            #endregion

            #region AutoModellen
            modelBuilder.Entity<AutoModell>().HasData(
                new AutoModell { AutoModellId = 200, Hersteller_RefId = 100, ModelName = "RangeRover Velar" },
                new AutoModell { AutoModellId = 201, Hersteller_RefId = 100, ModelName = "RangeRover Sport" },
                new AutoModell { AutoModellId = 202, Hersteller_RefId = 101, ModelName = "911" },
                new AutoModell { AutoModellId = 203, Hersteller_RefId = 101, ModelName = "Cayenne" },
                new AutoModell { AutoModellId = 204, Hersteller_RefId = 102, ModelName = "Model S" },
                new AutoModell { AutoModellId = 205, Hersteller_RefId = 102, ModelName = "Model X" },
                new AutoModell { AutoModellId = 206, Hersteller_RefId = 103, ModelName = "RS7" },
                new AutoModell { AutoModellId = 207, Hersteller_RefId = 103, ModelName = "RSQ8" },
                new AutoModell { AutoModellId = 208, Hersteller_RefId = 104, ModelName = "AMG GT" },
                new AutoModell { AutoModellId = 209, Hersteller_RefId = 104, ModelName = "GLE" },
                new AutoModell { AutoModellId = 210, Hersteller_RefId = 105, ModelName = "8er" },
                new AutoModell { AutoModellId = 211, Hersteller_RefId = 105, ModelName = "X6" }
            );
            #endregion

            #region Felgen
            modelBuilder.Entity<Felge>().HasData(
                new Felge { FelgeId = 300, Size = 18 },
                new Felge { FelgeId = 301, Size = 19 },
                new Felge { FelgeId = 302, Size = 20 },
                new Felge { FelgeId = 303, Size = 21 },
                new Felge { FelgeId = 304, Size = 22 }
            );
            #endregion

            #region AutoModell_Felge
            modelBuilder.Entity<AutoModell_Felge>().HasData(
                new AutoModell_Felge { AutoModell_FelgeId = 23000, AutoModellRefId = 200, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23001, AutoModellRefId = 200, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23002, AutoModellRefId = 200, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23003, AutoModellRefId = 200, FelgeRefId = 304 },
                new AutoModell_Felge { AutoModell_FelgeId = 23004, AutoModellRefId = 201, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23005, AutoModellRefId = 201, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23006, AutoModellRefId = 201, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23007, AutoModellRefId = 201, FelgeRefId = 304 },
                new AutoModell_Felge { AutoModell_FelgeId = 23008, AutoModellRefId = 202, FelgeRefId = 300 },
                new AutoModell_Felge { AutoModell_FelgeId = 23009, AutoModellRefId = 202, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23010, AutoModellRefId = 202, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23011, AutoModellRefId = 203, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23012, AutoModellRefId = 203, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23013, AutoModellRefId = 203, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23014, AutoModellRefId = 203, FelgeRefId = 304 },
                new AutoModell_Felge { AutoModell_FelgeId = 23015, AutoModellRefId = 204, FelgeRefId = 300 },
                new AutoModell_Felge { AutoModell_FelgeId = 23016, AutoModellRefId = 204, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23017, AutoModellRefId = 205, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23018, AutoModellRefId = 205, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23019, AutoModellRefId = 205, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23020, AutoModellRefId = 205, FelgeRefId = 304 },
                new AutoModell_Felge { AutoModell_FelgeId = 23021, AutoModellRefId = 206, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23022, AutoModellRefId = 206, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23023, AutoModellRefId = 207, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23024, AutoModellRefId = 207, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23025, AutoModellRefId = 207, FelgeRefId = 304 },
                new AutoModell_Felge { AutoModell_FelgeId = 23026, AutoModellRefId = 208, FelgeRefId = 300 },
                new AutoModell_Felge { AutoModell_FelgeId = 23027, AutoModellRefId = 208, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23028, AutoModellRefId = 208, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23029, AutoModellRefId = 209, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23030, AutoModellRefId = 209, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23031, AutoModellRefId = 209, FelgeRefId = 304 },
                new AutoModell_Felge { AutoModell_FelgeId = 23032, AutoModellRefId = 210, FelgeRefId = 300 },
                new AutoModell_Felge { AutoModell_FelgeId = 23033, AutoModellRefId = 210, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23034, AutoModellRefId = 210, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23035, AutoModellRefId = 211, FelgeRefId = 301 },
                new AutoModell_Felge { AutoModell_FelgeId = 23036, AutoModellRefId = 211, FelgeRefId = 302 },
                new AutoModell_Felge { AutoModell_FelgeId = 23037, AutoModellRefId = 211, FelgeRefId = 303 },
                new AutoModell_Felge { AutoModell_FelgeId = 23038, AutoModellRefId = 211, FelgeRefId = 304 }
                );
            #endregion

            #region Lackierungen
            modelBuilder.Entity<Lackierung>().HasData(
                new Lackierung { LackierungId = 400, Name = "Weiss" },
                new Lackierung { LackierungId = 401, Name = "Grau" },
                new Lackierung { LackierungId = 402, Name = "Schwarz" },
                new Lackierung { LackierungId = 403, Name = "Gruen" },
                new Lackierung { LackierungId = 404, Name = "Rot" },
                new Lackierung { LackierungId = 405, Name = "Braun" },
                new Lackierung { LackierungId = 406, Name = "Orange" },
                new Lackierung { LackierungId = 407, Name = "Blau" },
                new Lackierung { LackierungId = 408, Name = "Silber" },
                new Lackierung { LackierungId = 409, Name = "Oliv" },
                new Lackierung { LackierungId = 410, Name = "Gold" },
                new Lackierung { LackierungId = 411, Name = "Gelb" },
                new Lackierung { LackierungId = 412, Name = "Cyan" },
                new Lackierung { LackierungId = 413, Name = "Azurblau" }
                );
            #endregion

            #region AutoModellen_Lackierungen
            modelBuilder.Entity<AutoModell_Lackierung>().HasData(
                new AutoModell_Lackierung { AutoModell_LackierungId = 24000, AutoModellRefId = 200, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24001, AutoModellRefId = 200, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24002, AutoModellRefId = 200, LackierungRefId = 405 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24003, AutoModellRefId = 201, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24004, AutoModellRefId = 201, LackierungRefId = 401 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24005, AutoModellRefId = 201, LackierungRefId = 409 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24006, AutoModellRefId = 202, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24007, AutoModellRefId = 202, LackierungRefId = 404 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24008, AutoModellRefId = 202, LackierungRefId = 407 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 24009, AutoModellRefId = 203, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240010, AutoModellRefId = 203, LackierungRefId = 403 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240011, AutoModellRefId = 203, LackierungRefId = 407 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240012, AutoModellRefId = 204, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240013, AutoModellRefId = 204, LackierungRefId = 401 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240014, AutoModellRefId = 204, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240015, AutoModellRefId = 205, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240016, AutoModellRefId = 205, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240017, AutoModellRefId = 205, LackierungRefId = 404 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240018, AutoModellRefId = 206, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240019, AutoModellRefId = 206, LackierungRefId = 401 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240020, AutoModellRefId = 206, LackierungRefId = 412 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240021, AutoModellRefId = 207, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240022, AutoModellRefId = 207, LackierungRefId = 410 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240023, AutoModellRefId = 207, LackierungRefId = 403 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240024, AutoModellRefId = 208, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240025, AutoModellRefId = 208, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240026, AutoModellRefId = 208, LackierungRefId = 413 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240027, AutoModellRefId = 209, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240028, AutoModellRefId = 209, LackierungRefId = 401 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240029, AutoModellRefId = 209, LackierungRefId = 407 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240030, AutoModellRefId = 210, LackierungRefId = 401 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240031, AutoModellRefId = 210, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240032, AutoModellRefId = 210, LackierungRefId = 405 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240033, AutoModellRefId = 211, LackierungRefId = 400 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240034, AutoModellRefId = 211, LackierungRefId = 402 },
                new AutoModell_Lackierung { AutoModell_LackierungId = 240035, AutoModellRefId = 211, LackierungRefId = 409 }
                );
            #endregion

            #region Motoren
            modelBuilder.Entity<Motor>().HasData(
                new Motor { MotorId = 500, Leistung = 250},
                new Motor { MotorId = 501, Leistung = 550 }
                );
            #endregion

            #region Automodellen_Motoren
            modelBuilder.Entity<AutoModell_Motor>().HasData(
                new AutoModell_Motor { AutoModell_MotorId = 25000, AutoModellRefId = 200, MotorRefId = 501}
                );
            #endregion

            #region FahrSicherheitsSysteme
            modelBuilder.Entity<FahrSicherheitsSystem>().HasData(
                new FahrSicherheitsSystem { FahrSicherheitsSystemId = 6100, Name = "FSS1"},
                new FahrSicherheitsSystem { FahrSicherheitsSystemId = 6101, Name = "FSS2" }
                );
            #endregion

            #region KlimaAnlagen
            modelBuilder.Entity<KlimaAnlage>().HasData(
                new KlimaAnlage { KlimaAnlageId = 6200, Name = "KA1"},
                new KlimaAnlage { KlimaAnlageId = 6201, Name = "KA2" }
                );
            #endregion

            #region NavigationsSysteme
            modelBuilder.Entity<NavigationsSystem>().HasData(
                new NavigationsSystem { NavigationsSystemId = 6300, Model = "NS1"},
                new NavigationsSystem { NavigationsSystemId = 6301, Model = "NS2" }
                );
            #endregion

            #region ParkAssistentSysteme
            modelBuilder.Entity<ParkAssistentSystem>().HasData(
                new ParkAssistentSystem { ParkAssistentSystemId = 6400, Model = "PAS1"},
                new ParkAssistentSystem { ParkAssistentSystemId = 6401, Model = "PAS2" }
                );
            #endregion

            #region SoundSysteme
            modelBuilder.Entity<SoundSystem>().HasData(
                new SoundSystem { SoundSystemId = 6500, Model = "SS1"},
                new SoundSystem { SoundSystemId = 6501, Model = "SS2" }
                );
            #endregion

            #region AutoKonfigurationen
            modelBuilder.Entity<AutoKonfiguration>().HasData(
                new AutoKonfiguration { AutoKonfigurationId = 700000, AM_F_RefId = 23003, AM_L_RefId = 24002, AM_M_RefId = 25000, FSS_RefId = 6100, KA_RefId = 6200, NS_RefId = 6300, PAS_RefId = 6400, SS_RefId = 6500 }
                );
            #endregion

        }
    }
}

