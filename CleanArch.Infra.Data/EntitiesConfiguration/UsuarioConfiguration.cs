using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntitiesConfiguration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NomeUsuario).HasMaxLength(255).IsRequired();
        builder.Property(x => x.NomeCompleto).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Password).HasMaxLength(255).IsRequired();
        builder.Property(x => x.Situacao).HasMaxLength(50).IsRequired();

        builder.HasData(new Usuario(2, "teste", "Nome Completo Teste", "teste@gmail.com", "123456", "ATIVO"));
    }
}
