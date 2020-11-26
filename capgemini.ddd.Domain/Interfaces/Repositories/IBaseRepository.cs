using System.Collections.Generic;

namespace capgemini.ddd.Domain.Interfaces.Repositories
{
    public interface IBaseRepository
    {
        bool Add<T>(T entity) where T : class;
        void SaveChanges();
    }

}
