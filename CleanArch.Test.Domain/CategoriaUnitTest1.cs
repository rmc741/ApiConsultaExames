using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using FluentAssertions;

namespace CleanArch.Test.Domain;

public class CategoriaUnitTest1
{
    [Fact(DisplayName = "Criar Categoria com estado válido")]
    public void CreateCategoria_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Categoria("EXAME", "EXAMES");
        action.Should().NotThrow<DomainValidationException>();
    }

    [Fact(DisplayName = "Cria Categoria sem informar o Nome")]
    public void CreateCategoria_MissingNameValue_DomainExceptionRequiredName()
    {
        Action action = () => new Categoria("", "CONSULTA");
        action.Should().Throw<DomainValidationException>();
    }

    [Fact(DisplayName = "Cria Categoria sem informar o Tipo")]
    public void CreateCategoria_MissingTypeValue_DomainExceptionRequiredType()
    {
        Action action = () => new Categoria("Nome Categoria", "");
        action.Should().Throw<DomainValidationException>().WithMessage("Tipo da Categoria não pode ser nulo ou vazio!");
    }

    [Fact(DisplayName = "Cria Categoria informando Nome com caracteres insuficiente")]
    public void CreateCategoria_ShortNameValue_DomainExceptionShortName()
    {
        Action action = () => new Categoria("CA", "Tipo Categoria");
        action.Should().Throw<DomainValidationException>().WithMessage("Nome da Categoria NÃO pode possuir menos do que 3 caracteres!");
    }

    [Fact(DisplayName = "Cria Categoria informando Tipo da categoria com caracteres insuficiente")]
    public void CreateCategoria_ShortTypeValue_DomainExceptionShortType()
    {
        Action action = () => new Categoria("Nome Categoria", "CA");
        action.Should().Throw<DomainValidationException>().WithMessage("Tipo da Categoria NÃO pode possuir menos do que 3 caracteres!");
    }
}
