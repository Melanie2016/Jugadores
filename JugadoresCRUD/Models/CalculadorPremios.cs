using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Models
{
    public class CalculadorPremios
    {

        public static int CalcularTotalDePremios(List<Jugador> Jugadores)
        {
            int PremiosTotales = 0;

            foreach(var j in Jugadores )
            {
                PremiosTotales += j.CalcularPremios();
                
            }

            return PremiosTotales;

        }









    }
}