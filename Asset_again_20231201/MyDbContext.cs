
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Asset_20231201
{
    internal class MyDbContex : DbContext
    {
        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ToolsDb;Trusted_Connection=True;";

        public DbSet<Tool> Tools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}

