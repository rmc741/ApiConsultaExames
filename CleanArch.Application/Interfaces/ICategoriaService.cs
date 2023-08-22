using CleanArch.Application.DTOs;

namespace CleanArch.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> GetAll();
        Task<CategoriaDTO> GetById(int id);
        Task Add (CategoriaDTO categoriaDTO);
        Task Update (CategoriaDTO categoriaDTO);
        Task Delete (int id);
    }
}
