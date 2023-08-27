using Microsoft.EntityFrameworkCore;
using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpa.DAL.Databases
{
    public class AppplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=AMIRAGHAZALA;integrated security=SSPI;initial catalog=SimpaTravilingConsole;trustservercertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> users { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Comments> comments { get; set; }

    }
}
