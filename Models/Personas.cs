using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_De_Prestamos.Models
{
    public class Personas
    {
        [Key]

        [Required(ErrorMessage = "El campo 'PersonaId' no puede estar vacio")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El campo 'Nombre' no puede estar vacio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo 'Telefono' no puede estar vacio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo 'Cedula' no puede estar vacio")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo 'Dirección' no puede estar vacio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo 'Fecha' no puede estar vacio")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime FechaCumple { get; set; }

        public double Balance { get; set; }


    }
}
