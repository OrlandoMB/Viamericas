using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViamericasCareers.Repository
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Insert(T entity);
        T GetById(long id);
        void Delete(T entity);
    }
}
