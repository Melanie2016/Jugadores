using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD
{
    public class JugadorServicio
    {

        private jugadoresEntities1 MiBD = new jugadoresEntities1();


  

        public void Agregar(jugador j)
        {

            MiBD.jugador.Add(j);
            MiBD.SaveChanges();
         }

            
        public List<jugador> Listar()
        {

            return MiBD.jugador.ToList();

        }

   
        public void Eliminar(int id)
        {
            jugador jug = MiBD.jugador.FirstOrDefault(o => o.id == id);
            MiBD.jugador.Remove(jug);
            MiBD.SaveChanges();
            //MiBD.jugador.ToList().RemoveAll(j => j.Id == id);
        }

        /*
        public jugador ObtenerPorId(int id)
        {
            jugador jugadorEncontrado = null;

            foreach (jugador j in MiBD.jugador.ToList())
            {
                if (j.Id.Equals(id))
                {
                    jugadorEncontrado = j;
                }
            }

            return jugadorEncontrado;
        }
        */
        public void Modificar(jugador j)
        {
            // FirstOrDefault(o => o.Id == j.Id);
            jugador jug = MiBD.jugador.Find(j.id);

            jug.nombre = j.nombre;
            jug.apellido = j.apellido;
            jug.edad = j.edad;
            jug.posicion = j.posicion;

            MiBD.SaveChanges();

           }


        public jugador ObtenerPorId(int id)
        {
            return MiBD.jugador.Find(id);
        }

    }
}