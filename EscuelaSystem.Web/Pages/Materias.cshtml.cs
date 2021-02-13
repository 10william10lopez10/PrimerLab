using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class MateriasModel : PageModel
    {
        private readonly IMateriaRopositorys _materiaRepositorys;

        public MateriasModel(IMateriaRopositorys materiaRepositorys)
        {
            _materiaRepositorys = materiaRepositorys;
        }

        [BindProperty]
        public IEnumerable<Materia> Materias { get; set; }

        public IActionResult OnGet()
        {
            Materias = _materiaRepositorys.list();
            return Page();
        }
    }
}
