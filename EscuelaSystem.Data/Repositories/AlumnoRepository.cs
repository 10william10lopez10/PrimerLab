using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystem.Data.Repositories
{
    public class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {
        private readonly ApplicationDbContext _db;
        public AlumnoRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void hVirtual()
        {
            var Virtual = _db.Alumnos.Where(c => c.Virtual == true).ToList();
            _db.RemoveRange(Virtual);
            _db.SaveChanges();
        }

        }
}
