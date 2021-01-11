using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Testing2.Models
{
    public class Entidades
    {
        [Required(ErrorMessage = "Ingrese el numero de docuemento")]
        public int DNI { get; set; }

        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }

    }
}
