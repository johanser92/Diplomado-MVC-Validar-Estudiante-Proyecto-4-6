using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_Validar_Estudiante.Models
{
    public class Estudiante
    {   [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [MinLength(3,ErrorMessage ="El nombre del estudiante debe tener al menos 3 caracteres")]
        public String Nombres { get; set; }

        [Required(ErrorMessage = "El Apellido es Obligatorio")]
        [MinLength(2, ErrorMessage = "El Apellido del estudiante debe tener al menos 2 caracteres")]
        public String Apellidos { get; set; }

        [Range(14,65, ErrorMessage ="La edad del Estudiante debe de estar entre 14 y 65")]
        public int Edad { get; set; }

        [EmailAddress(ErrorMessage ="Debe ingrsar un mail valido")]
        public String Email { get; set; }

        [RegularExpression("[MmFf]", ErrorMessage ="Solo se puede ingresar una M=Masculino o F=Femenino")]
        public String Genero { get; set; }

        [RegularExpression("[CcSsVvDd]", ErrorMessage ="Solo puede ingresar una C=Casado, S=Soltero, U=Union Libre o D=Divociado")]
        public String EstadoCivil { get; set; }
    }
}