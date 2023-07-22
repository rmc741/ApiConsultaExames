using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task<IEnumerable<Usuario>> GetConsultas();
    Task<Usuario> GetById(int? id);
    Task<Usuario> Create(Usuario user);
    Task<Usuario> Update(Usuario user);
    Task<Usuario> Remove(Usuario user);
}
