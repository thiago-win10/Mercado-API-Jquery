﻿using Mercado.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mercado.Infraestrutura.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(x => x.FornecedorId);
            builder.Property(x => x.FornecedorId)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeFornecedor)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Cnpj)
                .HasColumnType("varchar(20)");

            builder.HasIndex(x => x.Cnpj)
                .IsUnique(true);

            builder.Property(x => x.Cep)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Rua)
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Numero)
                .HasColumnType("varchar(50)");

            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Cidade)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Estado)
                .HasColumnType("varchar(2)");

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");

            //Relacionamento
            //builder.HasMany(x => x.EnderecoClientePessoaFisicas)
            //    .WithOne(x => x.ClientePessoaFisica).HasForeignKey(c => c.EnderecoClientePessoaFisicaId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
