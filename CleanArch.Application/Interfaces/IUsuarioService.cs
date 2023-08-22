using CleanArch.Application.DTOs;

namespace CleanArch.Application.Interfaces;

public interface IUsuarioService
{
    Task<IEnumerable<UsuarioDTO>> GetAll();
    Task<UsuarioDTO> GetById(int id);
    Task Add(UsuarioDTO usuarioDTO);
    Task Update(UsuarioDTO usuarioDTO);
    Task Delete(int id);
}
