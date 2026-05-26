using LojinhaDevoNada.Models;
using Microsoft.EntityFrameworkCore;

namespace LojinhaDevoNada.Data
{
    public class LojinhaDbContext : DbContext
    {
        public LojinhaDbContext(
            DbContextOptions<LojinhaDbContext> options
        ) : base(options)
        {
        }

        public DbSet<Clientes> Clientes => Set<Clientes>();

        public DbSet<Dividas> Dividas => Set<Dividas>();

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            var modelClientes = modelBuilder.Entity<Clientes>();

            var modelDividas = modelBuilder.Entity<Dividas>();

            modelClientes.ToTable("clientes");

            modelClientes.HasKey(e => e.Id);
            modelClientes.Property(e => e.Id).HasColumnName("id");
            modelClientes.Property(e => e.Nome).HasColumnName("nome");
            modelClientes.Property(e => e.Cpf).HasColumnName("cpf");
            modelClientes.Property(e => e.Data_nasc).HasColumnName("data_nasc").HasColumnType("date");
            modelClientes.Property(e => e.Email).HasColumnName("email");
            modelClientes.HasIndex(e => e.Cpf).IsUnique();


            modelDividas.ToTable("dividas");

            modelDividas.HasKey(e => e.Id);
            modelDividas.Property(e => e.Id).HasColumnName("id");
            modelDividas.Property(e => e.Valor).HasColumnName("valor").HasColumnType("numeric(10,2)");
            modelDividas.Property(e => e.Status).HasColumnName("status");
            modelDividas.Property(e => e.Data_criacao).HasColumnName("data_criacao").HasColumnType("timestamp without time zone"); ;
            modelDividas.Property(e => e.Data_pagamento).HasColumnName("data_pagamento").HasColumnType("timestamp without time zone"); ;
            modelDividas.Property(e => e.ClienteId).HasColumnName("cliente_id");
            modelDividas
                .HasOne(d => d.Cliente)
                .WithMany(c => c.Dividas)
                .HasForeignKey(d => d.ClienteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}