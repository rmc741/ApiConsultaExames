using CleanArch.Application.DTOs;

namespace CleanArch.Application.Interfaces;

public interface IConsultaService
{
    Task<IEnumerable<ConsultaDTO>> GetAll();
    Task<ConsultaDTO> GetById(int id);
    Task Add(ConsultaDTO consultaDTO);
    Task Update(ConsultaDTO consultaDTO);
    Task Delete(int id);
}
