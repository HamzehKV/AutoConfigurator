using AutoConfiguratorApp.Models;
using AutoConfiguratorApp.Models.Auto;
using AutoConfiguratorApp.Models.SonderAusstattungen;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AutoConfiguratorApp.Data

{
    public class AkDbContext :DbContext
    {
        public AkDbContext(DbContextOptions<AkDbContext> options) :base(options)
        {

        }
        
        public DbSet<AutoModell> AutoModelle { get; set; }
        public DbSet<Felge> Felgen { get; set; }
        public DbSet<Lackierung> Lackierungen { get; set; }
        public DbSet<Motor> Motoren { get; set; }
        public DbSet<FahrSicherheitsSystem> FahrSicherheitsSysteme { get; set; }
        public DbSet<KlimaAnlage> KlimaAnlagen { get; set; }
        public DbSet<NavigationsSystem> NavigationsSysteme { get; set; }
        public DbSet<ParkAssistentSystem> ParkAssistentSysteme { get; set; }
        public DbSet<SoundSystem> SoundSysteme { get; set; }
        public DbSet<AutoKonfiguration> AutoKonfigurationen { get; set; }





    }
}

