using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Models
{
    public class Arquero : Jugador
    {

        public int GolesRecibidos  { get; set; }




        public override int CalcularPremios()
        {
            int penalidad = 100;

            return base.PremioBasico-(GolesRecibidos*penalidad);
        }






    }
}