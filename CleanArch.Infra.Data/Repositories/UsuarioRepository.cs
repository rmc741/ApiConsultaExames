using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public Task<Usuario> Create(Usuario user)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Usuario>> GetConsultas()
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> Remove(Usuario user)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> Update(Usuario user)
    {
        throw new NotImplementedException();
    }
}
