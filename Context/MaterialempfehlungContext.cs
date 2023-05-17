using Materialempfehlung.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Materialempfehlung.Context
{
    public class MaterialempfehlungContext : DbContext
    {        
        public MaterialempfehlungContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configurationBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
             .Build();
            var settings = configurationBuilder?.GetRequiredSection("Settings")?.Get<Settings>();
            optionsBuilder.UseSqlServer(settings?.TestConnectionString ?? string.Empty);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // damit alles übersichtlich bleibt, bekommen alle Tabellen einen Präfix
            modelBuilder.Entity<Äußerer_Einfluss>()
                .ToTable("MEL_Äußerer_Einfluss");

            modelBuilder.Entity<Bedingung>()
               .ToTable("MEL_Bedingungen");

            modelBuilder.Entity<Besonderheit>()
               .ToTable("MEL_Besonderheit");

            modelBuilder.Entity<Druckverfahren>()
               .ToTable("MEL_Druckverfahren");

            modelBuilder.Entity<Kategorie>()
               .ToTable("MEL_Kategorien");

            modelBuilder.Entity<Klebstoff>()
               .ToTable("MEL_Klebstoffe");

            modelBuilder.Entity<Oberfläche>()
               .ToTable("MEL_Oberflächen");

            modelBuilder.Entity<Oberfläche_Beschaffenheit>()
               .ToTable("MEL_Oberfläche_Beschaffenheiten");

            modelBuilder.Entity<Oberfläche_Farbe>()
              .ToTable("MEL_Oberfläche_Farben");

            modelBuilder.Entity<Oberfläche_Form>()
            .ToTable("MEL_Oberfläche_Formen");

            modelBuilder.Entity<Oberfläche_Zustand>()
            .ToTable("MEL_Oberfläche_Zustände");
        }

        public DbSet<Material> Materialien { get; set; }

        public DbSet<Äußerer_Einfluss> Äußere_Einflüsse { get;  set; }

        public DbSet<Bedingung> Bedingungen { get; set; }

        public DbSet<Besonderheit> Besonderheiten { get; set; }

        public DbSet<Druckverfahren> Druckverfahren { get; set; }

        public DbSet<Kategorie> Kategorien { get; set; }

        public DbSet<Klebstoff> Klebstoffe { get; set; }

        public DbSet<Oberfläche> Oberflächen { get; set; }

        public DbSet<Oberfläche_Beschaffenheit> Oberfläche_Beschaffenheiten { get; set; }

        public DbSet<Oberfläche_Farbe> Oberfläche_Farben { get; set; }

        public DbSet<Oberfläche_Form> Oberfläche_Formen { get; set; }

        public DbSet<Oberfläche_Zustand> Oberfläche_Zustände { get; set; }

        public DbSet<Veredelung> Veredelungen { get; set; }
    }
}
