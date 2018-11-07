using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Servicios
{
    public class EquipoServico
    {

        jugadoresEntities1 Contexto = new jugadoresEntities1();

        public List<equipo> ObtenerTodos()
        {

            //Contexto.equipo.ToList();
            var equipos = (from p in Contexto.equipo
                           select p).ToList();
            return equipos;
        }
    }
}