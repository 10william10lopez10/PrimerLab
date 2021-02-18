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
    public class ContratarDocenteModel : PageModel
    {
        private readonly IDocenteRepositorys _DocenteRepositorys;

        public ContratarDocenteModel(IDocenteRepositorys docenteRopositorys)
        {
            _DocenteRepositorys = docenteRopositorys;
        }
        [BindProperty]

        public Docente Docente { get; set; }
        public void OnGet()
        {
        }
        public ActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _DocenteRepositorys.Insert(Docente);

            return RedirectToPage("./Docentes");
        }

    }
}
