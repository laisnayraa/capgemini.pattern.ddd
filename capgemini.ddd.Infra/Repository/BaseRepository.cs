using capgemini.ddd.Domain.Interfaces.Repositories;
using capgemini.ddd.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace capgemini.ddd.Infra.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DataBaseContext _context;

        public BaseRepository(DataBaseContext context)
        {
            _context = context;
        }

        public bool Add<T>(T entity) where T : class
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void SaveChanges() 
        {
            _context.SaveChanges();
        }
    }
}
