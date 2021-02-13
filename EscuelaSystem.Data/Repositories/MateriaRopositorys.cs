using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystem.Data.Repositories
{
    public class MateriaRopositorys : Repository<Materia>, IMateriaRopositorys
    {
        private readonly ApplicationDbContext _db;
        public MateriaRopositorys(ApplicationDbContext db) : base(db)
        {

        }
        public void DeleteHabilitada()
        {
            var habilitadas = _db.Materias.Where(c => c.Habilitada == true).ToList();
            _db.RemoveRange(habilitadas);
            _db.SaveChanges();
        }
    }
}
