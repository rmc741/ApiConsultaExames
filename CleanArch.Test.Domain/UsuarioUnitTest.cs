using CleanArch.Domain.Entities;
using CleanArch.Domain.Validation;
using FluentAssertions;

namespace CleanArch.Test.Domain;

public class UsuarioUnitTest
{
    [Fact(DisplayName = "Cria usuario com parametros válidos")]
    public void CreateUsuario_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Usuario("Nome Usuario" , "Nome Completo", "Email Usuario", "SenhaUsuario" , "ATIVO");
        action.Should().NotThrow<DomainValidationException>();
    }

    [Fact(DisplayName = "Cria usuario com Nome de Usuario nulo ")]
    public void CreateUsuario_WithNullUserNameValue_DomainExceptionRequiredUserName()
    {
        Action action = () => new Usuario(null, "Nome Completo", "Email Usuario", "SenhaUsuario", "ATIVO");
        action.Should().Throw<DomainValidationException>().WithMessage("Nome de Usuário NÂO pode ser nulo ou vazio!");
    }

    [Fact(DisplayName = "Cria usuario com Nome nulo ")]
    public void CreateUsuario_WithNullNameValue_DomainExceptionRequiredName()
    {
        Action action = () => new Usuario("Nome Usuario", null, "Email Usuario", "SenhaUsuario", "ATIVO");
        action.Should().Throw<DomainValidationException>().WithMessage("Nome Completo NÂO pode ser nulo ou vazio!");
    }

    [Fact(DisplayName = "Cria usuario com Email nulo ")]
    public void CreateUsuario_WithNullEmailValue_DomainExceptionRequiredEmail()
    {
        Action action = () => new Usuario("Nome Usuario", "Nome Compelto", null, "SenhaUsuario", "ATIVO");
        action.Should().Throw<DomainValidationException>().WithMessage("Email NÂO pode ser nulo ou vazio!");
    }

    [Fact(DisplayName = "Cria usuario com Senha nula ")]
    public void CreateUsuario_WithNullPasswordValue_DomainExceptionRequiredPassword()
    {
        Action action = () => new Usuario("Nome Usuario", "Nome Compelto", "Email Usuario", null, "ATIVO");
        action.Should().Throw<DomainValidationException>().WithMessage("Senha não pode ser nula ou vazia");
    }

    [Fact(DisplayName = "Cria usuario com Situação nulo ")]
    public void CreateUsuario_WithNullStatusValue_DomainExceptionRequiredStatus()
    {
        Action action = () => new Usuario("Nome Usuario", "Nome Compelto", "Email Usuario", "SenhaUsuario", null);
        action.Should().Throw<DomainValidationException>().WithMessage("Necessário informar Situação do Usuário!");
    }
}
