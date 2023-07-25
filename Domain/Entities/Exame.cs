using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities;

public class Exame : EntityBase
{
    public string Descricao { get; set; }
    public DateTime DataExame { get; set; }
    public string MedicoCRM { get; set; }
    //public string ImagemExame { get; set; } Verificar a Possibilidade de ser um base64
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

    public Exame(string descricao, DateTime dataExame, string medicoCRM, int usuarioId, int categoriaId)
    {
        ValidadeDomain(descricao, dataExame, medicoCRM, usuarioId, categoriaId);        
    }

    public Exame(int id,string descricao, DateTime dataExame, string medicoCRM, int usuarioId, int categoriaId)
    {
        DomainValidationException.When(id <= 0, "Invalid Id value.");
        Id = id;
        ValidadeDomain(descricao, dataExame, medicoCRM, usuarioId, categoriaId);
    }    

    private void ValidadeDomain(string descricao, DateTime dataExame, string medicoCRM, int usuarioId, int categoriaId)
    {
        DomainValidationException.When(string.IsNullOrEmpty(descricao), "Descrição não pode ser vazio ou nulo!");
        DomainValidationException.When(descricao.Length < 3, "Descrição precisar ter pelo menos 3 caracteres!");

        DomainValidationException.When(dataExame <= DateTime.Now.Date, "Necessário uma data válida para exame!");

        DomainValidationException.When(string.IsNullOrEmpty(medicoCRM), "Necessario informar CRM do médico!");

        DomainValidationException.When(usuarioId <= 0, "Id do usuario não pode ser menor ou igual a 0, informar um Id de usuario válido");

        DomainValidationException.When(categoriaId <= 0, "Id da Categoria não pode ser menor ou igual a 0, informar um Id de categoria válido");

        Descricao = descricao;
        DataExame = dataExame;
        MedicoCRM = medicoCRM;
        UsuarioId = usuarioId;
        CategoriaId = categoriaId;
    }
}
