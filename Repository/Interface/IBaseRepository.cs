using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        T FindById(int id);
        int Insert(T entity);
        int Update(T entity);
        void Delete(int id);
        int Upsert(T entity);
    }
}
