using capgemini.ddd.Domain.Interfaces.Repositories;
using capgemini.ddd.Domain.Models;
using capgemini.ddd.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capgemini.ddd.Infra.Repository
{
    public class AlunoRepository : BaseRepository, IAlunoRepository
    {

        private readonly DataBaseContext _context;

        public AlunoRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public IList<Aluno> GetAll()
        {
            IQueryable<Aluno> query = _context.Aluno.OrderBy(_ => _.Id);
            return query.ToList();
        }
    }
}
