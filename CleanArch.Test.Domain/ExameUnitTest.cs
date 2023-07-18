using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using FluentAssertions;

namespace CleanArch.Test.Domain;

public class ExameUnitTest
{
    [Fact(DisplayName = "Cria Exame com parametros válidos")]
    public void CreateExame_WithValidParameters_ResultObjectValidState()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("Descrição", DateTime.Parse(formattedDate), "CRM Medico", 1, 1);
        action.Should().NotThrow<DomainValidationException>();
    }

    [Fact(DisplayName = "Cria Exame com Descrição nula")]
    public void CreateExame_WithNullDescriptionValue_DomainExceptionRequiredDescription()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame(null, DateTime.Parse(formattedDate), "CRM Médico", 1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Descrição não pode ser vazio ou nulo!");
    }

    [Fact(DisplayName = "Cria Exame com Data da consulta nula")]
    public void CreateExame_WithNullDateValue_DomainExceptionRequiredDate()
    {
        Action action = () => new Exame("Descrição", DateTime.Parse(null), "CRM Médico", 1, 1);
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact(DisplayName = "Cria Exame com CRM nula")]
    public void CreateExame_WithNullCrmValue_DomainExceptionRequiredCRM()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("Descrição", DateTime.Parse(formattedDate), null, 1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Necessario informar CRM do médico!");
    }

    [Fact(DisplayName = "Cria Exame com Id de usuario nulo")]
    public void CreateExame_WithNullUserIdValue_DomainExceptionRequiredUserId()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("Descrição", DateTime.Parse(formattedDate), "CRM Médico", Int16.Parse(null), 1);
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact(DisplayName = "Cria Exame com Id de categoria nulo")]
    public void CreateExame_WithNullCategoriaIdValue_DomainExceptionRequiredCategoriaId()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("Descrição", DateTime.Parse(formattedDate), "CRM Médico", 1, Int16.Parse(null));
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact(DisplayName = "Cria Exame com Descrição muito curta")]
    public void CreateExame_WithShortDescriptionValue_DomainExceptionShortDescription()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("De", DateTime.Parse(formattedDate), "CRM Médico", 1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Descrição precisar ter pelo menos 3 caracteres!");
    }

    [Fact(DisplayName = "Cria Exame com Id de usuario invalido")]
    public void CreateExame_WithInvalidUserIdValue_ExceptionDomainNegativeValue()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("Descrição", DateTime.Parse(formattedDate), "CRM Médico", -1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Id do usuario não pode ser menor ou igual a 0, informar um Id de usuario válido");
    }

    [Fact(DisplayName = "Cria Exame com Id de usuario invalido")]
    public void CreateExame_WithInvalidCategoriaIdValue_ExceptionDomainNegativeValue()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Exame("Descrição", DateTime.Parse(formattedDate), "CRM Médico", 1, -1);
        action.Should().Throw<DomainValidationException>().WithMessage("Id da Categoria não pode ser menor ou igual a 0, informar um Id de categoria válido");
    }
}
