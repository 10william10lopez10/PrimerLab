using System;
using EscuelaSystem.Models;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data.Intefaces
{
    public interface IDocenteRepositorys : IRepository<Docente>
    {
        void DeleteActivo();
    }
}
