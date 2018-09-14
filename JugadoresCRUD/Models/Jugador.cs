using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public int Edad { get; set; }

        public String Posicion { get; set; }



    }
}