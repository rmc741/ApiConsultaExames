using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    [DisplayName("NomeUsuario")]
    public string NomeUsuario { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    [DisplayName("NomeCompleto")]
    public string NomeCompleto { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(255)]
    [DisplayName("Email")]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    [DisplayName("Password")]
    public string Password { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    [DisplayName("Situacao")]
    public string Situacao { get; set; }

}
