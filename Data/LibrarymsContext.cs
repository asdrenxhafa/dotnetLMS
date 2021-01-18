using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Libraryms.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace Libraryms.Data
{
    public class LibrarymsContext : IdentityDbContext
    {
        public LibrarymsContext(DbContextOptions<LibrarymsContext> options)
            : base(options)
        { }

        public DbSet<Libraryms.Models.Libra> Libra { get; set; }

        public DbSet<Libraryms.Models.Klienti> Klienti { get; set; }

        public DbSet<Libraryms.Models.Huazimi> Huazimi { get; set; }
        public DbSet<Libraryms.Models.Rezervimi> Rezervimi { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libra>().ToTable("Libra");
            modelBuilder.Entity<Klienti>().ToTable("Klientet");
            modelBuilder.Entity<Huazimi>().ToTable("Huazimi");
            modelBuilder.Entity<Rezervimi>().ToTable("Rezervimi");
        }
    }
}
