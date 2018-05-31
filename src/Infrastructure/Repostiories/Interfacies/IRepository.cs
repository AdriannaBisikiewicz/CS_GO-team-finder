using System.Collections.Generic;
using CS_GO.Domain.Model;

namespace CS_GO.Repositories.Interfaces
{
    public interface IRepository<T>
    {
         T GetById(int id);

         IList<T> GetAll();

         void Add(T entity);
    }
}