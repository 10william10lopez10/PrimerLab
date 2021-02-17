using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EscuelaSystem.Data
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> List()
        {
           return _dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>()
                .Where(predicate)
                .AsEnumerable();
        }
        public void Insert(T Entity)
        {
            _dbContext.Set<T>().Add(Entity);
            _dbContext.SaveChanges();
        }

        public void Update(T Entity)
        {
            _dbContext.Entry(Entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public void Delete(T Entity)
        {
            _dbContext.Set<T>().Remove(Entity);
            _dbContext.SaveChanges();
        }
    }
}
