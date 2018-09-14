using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JugadoresCRUD.Models
{
    public class JugadorServicio
    {

        // la inicializo y no necesito un constructor, es privada para que no la modifique nadie mas 
        private static List<Jugador> Lista = new List<Jugador>();

        public void Agregar(Jugador j)
        {

            Lista.Add(new Jugador()
            {
                Id = j.Id,
                Nombre = j.Nombre,
                Apellido = j.Apellido,
                Edad = j.Edad,
                Posicion = j.Posicion

            });

        }


        public List<Jugador> Listar()
        {
            return Lista;

        }


        public void Eliminar(int id)
        {
            Lista.RemoveAll(j => j.Id == id);
        }


        public Jugador ObtenerPorId(int id)
        {
            Jugador jugadorEncontrado = null;

            foreach (Jugador j in Lista)
            {
                if (j.Id.Equals(id))
                {
                    jugadorEncontrado = j;
                }
            }

            return jugadorEncontrado;
        }

        public void Modificar(Jugador j)
        {

            Lista.RemoveAll(j1 => j1.Id == j.Id);
            Lista.Add(j);




        }
    }
}