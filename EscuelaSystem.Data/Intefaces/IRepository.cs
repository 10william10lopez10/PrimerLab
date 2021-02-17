using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EscuelaSystem.Data.Intefaces;

namespace EscuelaSystem.Data.Intefaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Insert(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
