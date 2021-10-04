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
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<ExperienciaProfissional> ExperienciaProfissional { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Qualificacao> Qualificacao { get; set; }
        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<Usuario>()
                .HasKey(u => u.UsuarioId);

            builder.Entity<Usuario>()
                .Property(u => u.UsuarioId).ValueGeneratedOnAdd();

            builder.Entity<Login>()
               .HasKey(l => l.LoginId);

            builder.Entity<Login>()
                .Property(l => l.LoginId).ValueGeneratedOnAdd();

            builder.Entity<Escolaridade>()
               .HasKey(e => e.EscolaridadeId);

            builder.Entity<Escolaridade>()
                .Property(e => e.EscolaridadeId).ValueGeneratedOnAdd();

            builder.Entity<ExperienciaProfissional>()
               .HasKey(e => e.ExpProfId);

            builder.Entity<ExperienciaProfissional>()
                .Property(e => e.ExpProfId).ValueGeneratedOnAdd();

            builder.Entity<Qualificacao>()
               .HasKey(q => q.QualificacaoId);

            builder.Entity<Qualificacao>()
                .Property(q => q.QualificacaoId).ValueGeneratedOnAdd();
        }
    }
}
