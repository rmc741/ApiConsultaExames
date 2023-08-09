using CleanArch.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CleanArch.Application.DTOs;

public class ConsultaDTO
{
    [Required(ErrorMessage = "Descrição é necessária")]
    [MinLength(3)]
    [MaxLength(255)]
    [DisplayName("Descricao")]
    public string Descricao { get; set; }

    [Required]
    [DisplayName("DataConsulta")]
    [DataType(DataType.DateTime)]
    public DateTime DataConsulta { get; set; }

    [Required(ErrorMessage = "MedicoCRM é necessário")]
    [MaxLength(100)]
    [DisplayName("MedicoCRM")]
    public string MedicoCRM { get; set; }

    [Required(ErrorMessage = "Id do usuario é obrigatorio")]
    [DisplayName("UsuarioId")]
    public int UsuarioId { get; set; }
    [JsonIgnore]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage = "Id da Categoria é obrigatorio")]
    [DisplayName("CategoriaId")]
    public int CategoriaId { get; set; }
    [JsonIgnore]
    public Categoria Categoria { get; set;}
}
