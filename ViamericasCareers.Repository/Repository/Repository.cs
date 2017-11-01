using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViamericasCareers.Data.DataContext;

namespace ViamericasCareers.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly ViamericasCareersEntities _context;
        private DbSet<T> _entity;

        public Repository(ViamericasCareersEntities context)
        {
            this._context = context;
            _entity = context.Set<T>();
        }


        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _entity.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public T GetById(long id)
        {
            return _entity.Find(id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _entity.Add(entity);
        }
    }
}
