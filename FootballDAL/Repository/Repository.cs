using FootballDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> _contextDbSet;
        private readonly FootbalDBContext _context;
        public Repository(FootbalDBContext context)
        {
            //_contextDbSet = context.Set<TEntity>();
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _contextDbSet.Add(entity);
        }

        public void Delete(int id)
        {
            TEntity entity = _contextDbSet.Find(id);
            if(entity!= null)
            {
            _contextDbSet.Remove(entity);
            }
        }

        public TEntity Get(int id)
        {
            return _contextDbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _contextDbSet.ToList();
        }

        public void Update(TEntity entity)
        {
            _contextDbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
