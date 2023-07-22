using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> GetCategorias();
    Task<Categoria> GetById(int? id);
    Task<Categoria> Create(Categoria categoria);
    Task<Categoria> Update(Categoria categoria);
    Task<Categoria> Remove(Categoria categoria);
}
