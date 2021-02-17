using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Data.Repositories;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class CrearMateriaModel : PageModel
    {
        private readonly IMateriaRopositorys _MateriaRopositorys;

        public CrearMateriaModel(IMateriaRopositorys materiaRopositorys)
        {
            _MateriaRopositorys = materiaRopositorys;
        }
        [BindProperty]

            public Materia Materia { get; set; }
            public void OnGet()
            {
            }
            public ActionResult Onpost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _MateriaRopositorys.Insert(Materia);

                return RedirectToPage("./Materias");
            }
        
    }
}
