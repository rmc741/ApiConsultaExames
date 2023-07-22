using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly ApplicationDbContext _usuarioContext;

    public UsuarioRepository(ApplicationDbContext usuarioContext)
    {
        _usuarioContext = usuarioContext;
    }

    public async Task<Usuario> Create(Usuario user)
    {
        _usuarioContext.Add(user);
        await _usuarioContext.SaveChangesAsync();
        return user;
    }

    public async Task<Usuario> GetById(int? id)
    {
        return await _usuarioContext.Usuarios.FindAsync(id);
    }

    public async Task<IEnumerable<Usuario>> GetConsultas()
    {
        return await _usuarioContext.Usuarios.OrderBy(u => u.Id).ToListAsync();
    }

    public async Task<Usuario> Remove(Usuario user)
    {
        _usuarioContext.Remove(user);
        await _usuarioContext.SaveChangesAsync();
        return user;
    }

    public async Task<Usuario> Update(Usuario user)
    {
        _usuarioContext.Update(user);
        await _usuarioContext.SaveChangesAsync();
        return user;
    }
}
