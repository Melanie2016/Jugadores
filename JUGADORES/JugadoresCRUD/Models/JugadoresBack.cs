using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Models
{
    public class JugadorBack
    {
        public int Id { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        public String Apellido { get; set; }

        public int Edad { get; set; }

        public String Posicion { get; set; }
    }
}