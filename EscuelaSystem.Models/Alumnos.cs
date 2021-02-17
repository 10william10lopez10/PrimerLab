using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.Models
{
    public class Alumno : EntityBase
    {
        [Required(ErrorMessage = "El campo Codigo de materia no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Codigo de materia debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Codigo de materia debe tener maximo 10 caracteres")]
        [Display(Name = "Codigo de Materia")]
        public string Carnet { get; set; }
        [Required(ErrorMessage = "El campo Nombre de materia no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre de materia debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre de materia debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre de Materia")]
        public string Nombre { get; set; }
        public bool Virtual { get; set; }
    }
}
