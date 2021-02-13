using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EscuelaSystem.Data.NewFolder
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetTById(int id);
        IEnumerable<T> list();

        IEnumerable<T> list(Expression<Func<T, bool>> predicate);
        void Insert(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
