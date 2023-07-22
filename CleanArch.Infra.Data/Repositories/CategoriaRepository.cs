using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly ApplicationDbContext _categoriaContext;

    public CategoriaRepository(ApplicationDbContext context)
    {
        _categoriaContext = context;
    }
    public async Task<Categoria> Create(Categoria categoria)
    {
        _categoriaContext.Add(categoria);
        await _categoriaContext.SaveChangesAsync();
        return categoria;
    }

    public async Task<Categoria> GetById(int? id)
    {
        return await _categoriaContext.Categorias.FindAsync(id);
    }

    public async Task<IEnumerable<Categoria>> GetCategorias()
    {
        return await _categoriaContext.Categorias.OrderBy(c => c.Nome).ToListAsync();
    }

    public async Task<Categoria> Remove(Categoria categoria)
    {
        _categoriaContext.Remove(categoria);
        await _categoriaContext.SaveChangesAsync();
        return categoria;
    }

    public async Task<Categoria> Update(Categoria categoria)
    {
        _categoriaContext.Update(categoria);
        await _categoriaContext.SaveChangesAsync();
        return categoria;
    }
}
