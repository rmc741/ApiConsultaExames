using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities;

public class Consulta : EntityBase
{
    public string Descricao { get; set; }
    public DateTime DataConsulta { get; set; }
    public string MedicoCRM { get; set; }
    //public string ImagemConsulta { get; set; } Verificar a Possibilidade de receber um base64 para receber imagem
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

    public Consulta(string descricao, DateTime dataConsulta, string medicoCRM, int usuarioId, int categoriaId)
    {
        ValidadeDomain(descricao,dataConsulta,medicoCRM,usuarioId,categoriaId);
    }

    public Consulta(int id,string descricao, DateTime dataConsulta, string medicoCRM, int usuarioId, int categoriaId)
    {
        DomainValidationException.When(id <= 0, "Invalid Id value.");
        Id = id;
        ValidadeDomain(descricao, dataConsulta, medicoCRM, usuarioId, categoriaId);
    }

    private void ValidadeDomain(string descricao, DateTime dataConsulta, string medicoCRM, int usuarioId, int categoriaId)
    {
        DomainValidationException.When(string.IsNullOrEmpty(descricao), "Descrição não pode ser vazio ou nulo!");
        DomainValidationException.When(descricao.Length < 3, "Descrição precisar ter pelo menos 3 caracteres!");

        DomainValidationException.When(dataConsulta <= DateTime.Now, "Necessário uma data válida para consulta!");

        DomainValidationException.When(string.IsNullOrEmpty(medicoCRM), "Necessario informar CRM do médico!");

        DomainValidationException.When(usuarioId <= 0, "Id do usuario não pode ser menor ou igual a 0, informar um Id de usuario válido");

        DomainValidationException.When(categoriaId <= 0, "Id da Categoria não pode ser menor ou igual a 0, informar um Id de categoria válido");

        Descricao = descricao;
        DataConsulta = dataConsulta;
        MedicoCRM = medicoCRM;
        UsuarioId = usuarioId;
        CategoriaId = categoriaId;
    }
}
