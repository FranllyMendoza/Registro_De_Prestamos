using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_De_Prestamos.Models
{
    public class MorasDetalle
    {

        [Key]
        public int Id { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public string NombrePersona { get; set; }
        public float Valor { get; set; }
    }
}
