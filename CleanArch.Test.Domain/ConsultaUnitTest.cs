using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Test.Domain;

public class ConsultaUnitTest
{
    [Fact(DisplayName = "Cria uma consulta com Parametros validos.")]
    public void CreateConsulta_WithValidParameters_ResultObjectValidState()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), "CRM Medico", 1, 1);
        action.Should().NotThrow<DomainValidationException>();
    }

    [Fact(DisplayName = "Cria uma consulta com Descrição nula")]
    public void CreateConsulta_WithNullDescriptionValue_DomainExceptionRequiredDescription()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta(null, DateTime.Parse(formattedDate), "CRM Médico" , 1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Descrição não pode ser vazio ou nulo!");
    }

    [Fact(DisplayName = "Cria uma consulta com Data da consulta nula")]
    public void CreateConsulta_WithNullDateValue_DomainExceptionRequiredDate()
    {
       Action action = () => new Consulta("Descrição", DateTime.Parse(null), "CRM Médico", 1, 1);
       action.Should().Throw<ArgumentNullException>();
    }

    [Fact(DisplayName = "Cria uma consulta com CRM nula")]
    public void CreateConsulta_WithNullCrmValue_DomainExceptionRequiredCRM()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), null, 1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Necessario informar CRM do médico!");
    }

    [Fact(DisplayName = "Cria Consulta com Id de usuario nulo")]
    public void CreateConsulta_WithNullUserIdValue_DomainExceptionRequiredUserId()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), "CRM Médico", Int16.Parse(null), 1);
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact(DisplayName = "Cria Consulta com Id de categoria nulo")]
    public void CreateConsulta_WithNullCategoriaIdValue_DomainExceptionRequiredCategoriaId()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), "CRM Médico", 1, Int16.Parse(null));
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact(DisplayName = "Cria uma consulta com Descrição muito curta")]
    public void CreateConsulta_WithShortDescriptionValue_DomainExceptionShortDescription()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("De", DateTime.Parse(formattedDate), "CRM Médico", 1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Descrição precisar ter pelo menos 3 caracteres!");
    }

    [Fact(DisplayName = "Cria Consulta com Id de usuario invalido")]
    public void CreateConsulta_WithInvalidUserIdValue_ExceptionDomainNegativeValue()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), "CRM Médico", -1, 1);
        action.Should().Throw<DomainValidationException>().WithMessage("Id do usuario não pode ser menor ou igual a 0, informar um Id de usuario válido");
    }

    [Fact(DisplayName = "Cria Consulta com Id de usuario invalido")]
    public void CreateConsulta_WithInvalidCategoriaIdValue_ExceptionDomainNegativeValue()
    {
        DateTime data = DateTime.Now.AddDays(2);
        var formattedDate = String.Format("{0:dd/MM/yyyy}", data);
        Action action = () => new Consulta("Descrição", DateTime.Parse(formattedDate), "CRM Médico", 1, -1);
        action.Should().Throw<DomainValidationException>().WithMessage("Id da Categoria não pode ser menor ou igual a 0, informar um Id de categoria válido");
    }

}
