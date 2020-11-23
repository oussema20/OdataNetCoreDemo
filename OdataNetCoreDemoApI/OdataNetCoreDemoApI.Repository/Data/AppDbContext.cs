using Microsoft.EntityFrameworkCore;
using OdataNetCoreDemoApI.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdataNetCoreDemoApI.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().Property(p => p.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
