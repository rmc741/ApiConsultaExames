﻿using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntitiesConfiguration;

public class ExameConfiguration : IEntityTypeConfiguration<Exame>
{
    public void Configure(EntityTypeBuilder<Exame> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();
        builder.Property(x => x.DataExame).IsRequired();
        builder.Property(x => x.MedicoCRM).HasMaxLength(100).IsRequired();
        builder.Property(x => x.UsuarioId).IsRequired();
        builder.Property(x => x.CategoriaId).IsRequired();

        builder.HasOne(x => x.Categoria).WithMany(x => x.UsuarioExames).HasForeignKey(x => x.CategoriaId);
        builder.HasOne(x => x.Usuario).WithMany(x => x.Exames).HasForeignKey(x => x.UsuarioId);
    }
}
