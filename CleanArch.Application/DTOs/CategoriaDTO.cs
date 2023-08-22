using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs;

public class CategoriaDTO
{
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    public string Nome { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(100)]
    public string TipoCategoria { get; set; }
}
