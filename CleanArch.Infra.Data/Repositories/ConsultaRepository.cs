using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Data.Repositories;

public class ConsultaRepository : IConsultaRepository
{
    public Task<Consulta> Create(Consulta consulta)
    {
        throw new NotImplementedException();
    }

    public Task<Consulta> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Consulta>> GetConsultas()
    {
        throw new NotImplementedException();
    }

    public Task<Consulta> Remove(Consulta consulta)
    {
        throw new NotImplementedException();
    }

    public Task<Consulta> Update(Consulta consulta)
    {
        throw new NotImplementedException();
    }
}
