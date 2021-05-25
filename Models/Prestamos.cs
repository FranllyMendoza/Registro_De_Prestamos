using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_De_Prestamos.Models
{
    public class Prestamos
    {
      [Key]
        [Required(ErrorMessage = "Este campo no debe de estar vacio")]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Este campo no debe de estar vacio")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo no debe de estar vacio")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Este campo no debe de estar vacio")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Este campo no debe de estar vacio")]
        public float Monto { get; set; }

        [Required(ErrorMessage = "Este campo no debe de estar vacio")]
        public float Balance { get; set; }

        


    }
}
