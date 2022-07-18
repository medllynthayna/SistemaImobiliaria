using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ImobiliariaDB.Models.Imobiliaria;

namespace ImobiliariaDB.Models.Contexts
{
    public partial class dbimovelContext : DbContext
    {
        public dbimovelContext()
        {
        }

        public dbimovelContext(DbContextOptions<dbimovelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<imovel> imovels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=dbimovel;uid=root;pwd=admin123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<imovel>(entity =>
            {
                entity.HasKey(e => e.idimovel)
                    .HasName("PRIMARY");

                entity.ToTable("imovel");

                entity.Property(e => e.descricao).HasMaxLength(50);

                entity.Property(e => e.ds_bairro).HasMaxLength(50);

                entity.Property(e => e.ds_cidade).HasMaxLength(50);

                entity.Property(e => e.ds_complemento).HasMaxLength(50);

                entity.Property(e => e.ds_email).HasMaxLength(30);

                entity.Property(e => e.ds_estado).HasMaxLength(14);

                entity.Property(e => e.ds_logradouro).HasMaxLength(100);

                entity.Property(e => e.ds_nome_proprietario).HasMaxLength(50);

                entity.Property(e => e.nr_cep).HasMaxLength(15);

                entity.Property(e => e.nr_endereco).HasMaxLength(10);

                entity.Property(e => e.nr_telefone).HasMaxLength(20);

                entity.Property(e => e.vl_aluguel).HasPrecision(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
