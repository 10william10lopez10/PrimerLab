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
    public class EditarMateriaModel : PageModel
    {
        private readonly IMateriaRopositorys _MateriaRopositorys;

        public EditarMateriaModel(IMateriaRopositorys materiaRopositorys)
        {
            _MateriaRopositorys = materiaRopositorys;
        }

        [BindProperty]

        public Materia Materia { get; set; }
        public ActionResult OnGet(int id)
        {
            Materia = _MateriaRopositorys.GetTById(id);
            if(Materia == null)
            {
                return NotFound();
            }
            return Page();
        }
        public ActionResult Onpost(int id)
        {
            if (ModelState.IsValid)
            {
                return Page();
            }

            var MateriaToUpdate = _MateriaRopositorys.GetTById(id);
            if (MateriaToUpdate == null)
                return NotFound();

            MateriaToUpdate.Codigo = Materia.Codigo;
            MateriaToUpdate.Descripcion = Materia.Descripcion;
            MateriaToUpdate.Habilitada = Materia.Habilitada;

            _MateriaRopositorys.Update(MateriaToUpdate);

            return RedirectToPage("./Materias");
        }
    }
}
