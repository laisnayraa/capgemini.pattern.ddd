using capgemini.ddd.Domain.Interfaces.Repositories;
using capgemini.ddd.Domain.Models;
using capgemini.ddd.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace capgemini.ddd.Domain.Interfaces.Services
{
    public interface ITurmaService
    {
        IEnumerable<Turma> GetAll();
        bool Add(Turma value);
    }
}