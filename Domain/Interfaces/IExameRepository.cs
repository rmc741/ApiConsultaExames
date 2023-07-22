using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces;

public interface IExameRepository
{
    Task<IEnumerable<Exame>> GetConsultas();
    Task<Exame> GetById(int? id);
    Task<Exame> Create(Exame exame);
    Task<Exame> Update(Exame exame);
    Task<Exame> Remove(Exame exame);
}
