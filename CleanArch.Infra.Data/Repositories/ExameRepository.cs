using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repositories;

public class ExameRepository : IExameRepository
{
    private ApplicationDbContext _emaxeContext;

    public ExameRepository(ApplicationDbContext emaxeContext)
    {
        _emaxeContext = emaxeContext;
    }

    public Task<Exame> Create(Exame exame)
    {
        throw new NotImplementedException();
    }

    public Task<Exame> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Exame>> GetConsultas()
    {
        throw new NotImplementedException();
    }

    public Task<Exame> Remove(Exame exame)
    {
        throw new NotImplementedException();
    }

    public Task<Exame> Update(Exame exame)
    {
        throw new NotImplementedException();
    }
}
