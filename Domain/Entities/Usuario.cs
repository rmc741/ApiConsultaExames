using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities;

public class Usuario : EntityBase
{
    public string NomeUsuario { get; set; }
    public string NomeCompleto { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Situacao { get; set; }
    public ICollection<Consulta> Consultas { get; set; }
    public ICollection<Exame> Exames { get; set; }

    public Usuario(string nomeUsuario, string nomeCompleto, string email, string password, string situacao)
    {
        ValidadeDomain(nomeUsuario, nomeCompleto, email, password, situacao);
    }

    private void ValidadeDomain(string nomeUsuario, string nomeCompleto, string email, string password, string situacao)
    {
        DomainValidationException.When(string.IsNullOrEmpty(nomeUsuario), "Nome de Usuário NÂO pode ser nulo ou vazio!");
        DomainValidationException.When(nomeUsuario.Length < 3, "Nome de Usuário invalido, Nome de Usuário precisa ter pelo menos 3 caracteres!");

        DomainValidationException.When(string.IsNullOrEmpty(nomeCompleto), "Nome Completo NÂO pode ser nulo ou vazio!");
        DomainValidationException.When(nomeCompleto.Length < 3, "Necessário informar Nome Completo");

        DomainValidationException.When(string.IsNullOrEmpty(email), "Email NÂO pode ser nulo ou vazio!");
        DomainValidationException.When(email.Length < 3, "Necessário informar Email valido");

        DomainValidationException.When(string.IsNullOrEmpty(password), "Senha não pode ser nula ou vazia");
        DomainValidationException.When(password.Length < 6, "Senha precisa ter no minimo 6 caracteres");

        DomainValidationException.When(string.IsNullOrEmpty(situacao), "Necessário informar Situação do Usuário!");

        NomeUsuario = nomeUsuario;
        NomeCompleto = nomeCompleto;
        Email = email;
        Password = password;
        Situacao = situacao;
    }
}
