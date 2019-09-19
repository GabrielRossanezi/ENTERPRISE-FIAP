using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Persitences
{
    public class BancoContext : DbContext
    {
        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Construtora> Construtoras { get; set; }
        public DbSet<Sindico> Sindicos { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            // Configurar as Chaves primária da tabela

            builder.Entity<CondominioContrutora>()
                .HasKey(c => new { c.CondominioId, c.ConstrutoraId });

            // Configurar o relacionamento com o condominio
            builder.Entity<CondominioContrutora>()
                .HasOne(c => c.Condominio)
                .WithMany(c => c.CondominioContrutoras)
                .HasForeignKey(c => c.CondominioId);

            builder.Entity<CondominioContrutora>()
                .HasOne(c => c.Construtora)
                .WithMany(c => c.CondominioContrutoras)
                .HasForeignKey(c => c.ConstrutoraId);


            base.OnModelCreating(builder);

        }

        public BancoContext(DbContextOptions o) : base(o)
        {

        }
    }
}
