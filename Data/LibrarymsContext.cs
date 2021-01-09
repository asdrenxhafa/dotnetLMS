using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Libraryms.Models;

namespace Libraryms.Data
{
    public class LibrarymsContext : DbContext
    {
        public LibrarymsContext (DbContextOptions<LibrarymsContext> options)
            : base(options)
        { }

        public DbSet<Libraryms.Models.Libra> Libra { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libra>().ToTable("Libra");
        }
    }
}
