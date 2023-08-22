using CleanArch.Application.DTOs;

namespace CleanArch.Application.Interfaces;

public interface IExameService
{
    Task<IEnumerable<ExameDTO>> GetAll();
    Task<ExameDTO> GetById(int id);
    Task Add(ExameDTO exameDTO);
    Task Update(ExameDTO exameDTO);
    Task Delete(int id);
}
