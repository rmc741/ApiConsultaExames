using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories;

public class ExameRepository : IExameRepository
{
    private readonly ApplicationDbContext _emaxeContext;

    public ExameRepository(ApplicationDbContext emaxeContext)
    {
        _emaxeContext = emaxeContext;
    }

    public async Task<Exame> Create(Exame exame)
    {
        _emaxeContext.Add(exame);
        await _emaxeContext.SaveChangesAsync();
        return exame;
    }

    public async Task<Exame> GetById(int? id)
    {
        return await _emaxeContext.Exames.FindAsync(id);
    }

    public async Task<IEnumerable<Exame>> GetConsultas()
    {
        return await _emaxeContext.Exames.OrderBy(x => x.Id).ToListAsync();
    }

    public async Task<Exame> Remove(Exame exame)
    {
        _emaxeContext.Remove(exame);
        await _emaxeContext.SaveChangesAsync();
        return exame;
    }

    public async Task<Exame> Update(Exame exame)
    {
        _emaxeContext.Update(exame);
        await _emaxeContext.SaveChangesAsync();
        return exame;
    }
}
