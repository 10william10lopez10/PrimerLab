using EscuelaSystem.Data.NewFolder;
using EscuelaSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data.Intefaces
{
    public interface IMateriaRopositorys : IRepository<Materia>
    {
        void DeleteHabilitada();
    }
}
