using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntitiesConfiguration;

public class ConsultaConfiguration : IEntityTypeConfiguration<Consulta>
{
    public void Configure(EntityTypeBuilder<Consulta> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();
        builder.Property(x => x.DataConsulta).IsRequired();
        builder.Property(x => x.MedicoCRM).HasMaxLength(100).IsRequired();
        builder.Property(x =>x.UsuarioId).IsRequired();
        builder.Property(x =>x.CategoriaId).IsRequired();

        builder.HasOne(x => x.Categoria).WithMany(x => x.UsuarioConsultas).HasForeignKey(x => x.CategoriaId);
    }
}
