using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Models
{
    public class Delantero : Jugador
    {

        public int GolesConvertidos { get; set; }


        public override int CalcularPremios()
        {
            int PremioPorGol = 500;
            return base.PremioBasico + (GolesConvertidos*PremioPorGol);
        }







    }
}