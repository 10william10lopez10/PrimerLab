using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystem.Data.Repositories
{
    public class DocenteRepository : Repository<Docente>, IDocenteRepositorys
    {
        private readonly ApplicationDbContext _db;
        public DocenteRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void DeleteActivo()
        {
            var Activo = _db.Docentes.Where(c => c.Activo == true).ToList();
            _db.RemoveRange(Activo);
            _db.SaveChanges();
        }

    }
}

