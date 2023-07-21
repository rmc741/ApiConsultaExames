using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories;

public class ConsultaRepository : IConsultaRepository
{
    private ApplicationDbContext _consultaContext;

    public ConsultaRepository(ApplicationDbContext consultaContext)
    {
        _consultaContext = consultaContext;
    }

    public async Task<Consulta> Create(Consulta consulta)
    {
        _consultaContext.Add(consulta);
        await _consultaContext.SaveChangesAsync();
        return consulta;
    }

    public async Task<Consulta> GetById(int? id)
    {
        return await _consultaContext.Consultas.FindAsync(id);
    }

    public async Task<IEnumerable<Consulta>> GetConsultas()
    {
        return await _consultaContext.Consultas.OrderBy(x => x.Id).ToListAsync();
    }

    public async Task<Consulta> Remove(Consulta consulta)
    {
        _consultaContext.Remove(consulta);
        await _consultaContext.SaveChangesAsync();
        return consulta;
    }

    public async Task<Consulta> Update(Consulta consulta)
    {
        _consultaContext.Update(consulta);
        await _consultaContext.SaveChangesAsync();
        return consulta;
    }
}
