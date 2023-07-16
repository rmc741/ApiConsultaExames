using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Data.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    public Task<Categoria> Create(Categoria categoria)
    {
        throw new NotImplementedException();
    }

    public Task<Categoria> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Categoria>> GetCategorias()
    {
        throw new NotImplementedException();
    }

    public Task<Categoria> Remove(Categoria categoria)
    {
        throw new NotImplementedException();
    }

    public Task<Categoria> Update(Categoria categoria)
    {
        throw new NotImplementedException();
    }
}
