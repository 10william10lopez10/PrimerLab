using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data.Intefaces
{
    public interface IAlumnoRepository : IRepository<Alumno>
    {
        void DeleteVirtual();
    }
}
