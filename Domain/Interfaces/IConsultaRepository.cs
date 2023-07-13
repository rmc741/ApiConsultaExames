using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces;

public interface IConsultaRepository
{
    Task<IEnumerable<Consulta>> GetConsultas();

    Task<Consulta> GetById(int id);
    Task<Consulta> Create(Consulta consulta);
    Task<Consulta> Update(Consulta consulta);
    Task<Consulta> Remove(Consulta consulta);
}
