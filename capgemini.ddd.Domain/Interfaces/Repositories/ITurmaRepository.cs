using capgemini.ddd.Domain.Models;
using System.Collections.Generic;

namespace capgemini.ddd.Domain.Interfaces.Repositories
{
    public interface ITurmaRepository
    {
        IList<Turma> GetAll();
    }
}
