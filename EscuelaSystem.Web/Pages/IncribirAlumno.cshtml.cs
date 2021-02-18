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
    public class IncribirAlumnoModel : PageModel
{
    private readonly IAlumnoRepository _AlumnoRopositorys;

    public IncribirAlumnoModel(IAlumnoRepository alumnoRepositorys)
    {
        _AlumnoRopositorys = alumnoRepositorys;
    }
    [BindProperty]

    public Alumno Alumno { get; set; }
    public void OnGet()
    {
    }
    public ActionResult Onpost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

            _AlumnoRopositorys.Insert(Alumno);

        return RedirectToPage("./Alumnos");
    }

}
}

