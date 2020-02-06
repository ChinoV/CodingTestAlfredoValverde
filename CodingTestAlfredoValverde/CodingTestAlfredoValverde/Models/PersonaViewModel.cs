using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTestAlfredoValverde.Models
{
    public class PersonaViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Display(Name = "Teléfono")] 
        public string Telefono { get; set; }
        [Required]
        [Display(Name = "Género")]
        public string Genero { get; set; }
        [Display(Name = "Ocupación")]
        public string Ocupacion { get; set; }
    }
}
