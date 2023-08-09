using CleanArch.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CleanArch.Application.DTOs;

public class ExameDTO
{
    [Required(ErrorMessage = "Descrição é Necessária")]
    [MinLength(3)]
    [MaxLength(255)]
    [DisplayName("Descricao")]
    public string Descricao { get; set; }

    [Required]
    [DisplayName("DataExame")]
    [DataType(DataType.DateTime)]
    public DateTime DataExame { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("MedicoCRM")]
    public string MedicoCRM { get; set; }

    [Required]
    [DisplayName("UsuarioId")]
    public int UsuarioId { get; set; }
    [JsonIgnore]
    public Usuario Usuario { get; set; }

    [Required]
    [DisplayName("CategoriaId")]
    public int CategoriaId { get; set; }
    [JsonIgnore]
    public Categoria Categoria { get; set;}
}
