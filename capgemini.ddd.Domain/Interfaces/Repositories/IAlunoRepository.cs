using capgemini.ddd.Domain.Models;
using System.Collections.Generic;

namespace capgemini.ddd.Domain.Interfaces.Repositories
{
    public interface IAlunoRepository
    {
        IList<Aluno> GetAll();
    }
}
