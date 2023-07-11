using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities;

public class Categoria : EntityBase
{
    public string Nome { get; set; }
    public string TipoCategoria { get; set; } // Tipo Categoria pode ser um enum Ex: CONSULTA / EXAME
    public ICollection<Consulta> UsuarioConsultas { get; set; }
    public ICollection<Exame> UsuarioExames { get; set; }

    public Categoria(string nome, string tipoCategoria)
    {
        ValidadeDomain(nome, tipoCategoria);

    }

    private void ValidadeDomain(string nome, string tipoCategoria)
    {
        DomainValidationException.When(string.IsNullOrEmpty(nome), "Nome da Categoria não pode ser nulo ou vazio!");
        DomainValidationException.When(nome.Length < 3, "Nome da Categoria NÃO pode possuir menos do que 3 caracteres!");

        DomainValidationException.When(string.IsNullOrEmpty(tipoCategoria), "Tipo da Categoria não pode ser nulo ou vazio!");
        DomainValidationException.When(tipoCategoria.Length < 3, "Tipo da Categoria NÃO pode possuir menos do que 3 caracteres!");

        Nome = nome;
        TipoCategoria = tipoCategoria;
    }
}
