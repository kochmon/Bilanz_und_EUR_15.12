using System.Collections.Generic;
using System.Reflection.Emit;

namespace Bilanz_und_EUR_15._12.Models
{
    public class FinanzDbContext : DbContext
    {
        public FinanzDbContext(DbContextOptions<FinanzDbContext> options) : base(options)
        {
        }

        public DbSet<Bilanz> Bilanzen { get; set; } // DbSet für die Bilanz-Tabelle
        public DbSet<GewinnVerlust> GewinnVerluste { get; set; } // DbSet for the GewinnVerluist table
        public DbSet<Konto> Kontos { get; set; } // DbSet for the Konto table


        // Weitere DbSets für andere Modelle hier hinzufügen, z.B. DbSet<GewinnUndVerlustrechnung> usw.

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Konfigurationen für deine Modelle hier hinzufügen (falls erforderlich)
        //    base.OnModelCreating(modelBuilder); // Vergiss nicht, die Basisimplementierung aufzurufen

        //}
    }
}
