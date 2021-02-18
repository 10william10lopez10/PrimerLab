using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Intefaces;
using EscuelaSystem.Data.Repositories;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages.Docentes
{
    public class DocentesModel : PageModel
    {

        private readonly IDocenteRepositorys _docentesRepository;

        public DocentesModel(IDocenteRepositorys DocentesRepository)
        {
            _docentesRepository = DocentesRepository;
        }

        [BindProperty]
        public IEnumerable<Docente> Docentes { get; set; }

        public IActionResult OnGet()
        {
            Docentes = _docentesRepository.List();
            return Page();
        }
    }
}
