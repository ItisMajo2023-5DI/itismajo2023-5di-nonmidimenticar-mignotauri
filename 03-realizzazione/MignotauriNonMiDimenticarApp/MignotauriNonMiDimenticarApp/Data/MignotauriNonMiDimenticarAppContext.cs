using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MignotauriNonMiDimenticarApp.Models;

namespace MignotauriNonMiDimenticarApp.Data
{
    public class MignotauriNonMiDimenticarAppContext : DbContext
    {
        public MignotauriNonMiDimenticarAppContext (DbContextOptions<MignotauriNonMiDimenticarAppContext> options)
            : base(options)
        {
        }

        public DbSet<Diplomato> Diplomati { get; set; }
        public DbSet<Posizione> Posizioni { get; set; }
        public DbSet<Profilo> Profili { get; set; }
        public DbSet<Scuola> Scuole { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diplomato>().ToTable("Diplomato");
            modelBuilder.Entity<Posizione>().ToTable("Posizione");
            modelBuilder.Entity<Profilo>().ToTable("Profilo");
            modelBuilder.Entity<Scuola>().ToTable("Scuola");

        }
    }
}
