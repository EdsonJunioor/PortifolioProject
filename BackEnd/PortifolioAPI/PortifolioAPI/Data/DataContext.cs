using Microsoft.EntityFrameworkCore;
using PortifolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                .HasData(new List<Usuario>(){
                    new Usuario(1, "Edson Junior", 25, "edsonfjr@outlook.com.br", null, null)
                });
        }
    }
}
