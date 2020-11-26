using capgemini.ddd.Domain.Interfaces.Repositories;
using capgemini.ddd.Domain.Models;
using capgemini.ddd.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capgemini.ddd.Infra.Repository
{
    public class TurmaRepository : BaseRepository, ITurmaRepository
    {
        private readonly DataBaseContext _context;

        public TurmaRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public IList<Turma> GetAll()
        {
            IQueryable<Turma> query = _context.Turma.OrderBy(_ => _.Id);
            return query.ToList();

        }
    }
}
