using JugadoresCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JugadoresCRUD.Controllers
{
    public class JugadorController : Controller
    {
        JugadorServicio serviceJugador = new JugadorServicio();

        // GET: Jugador
        public ActionResult Listado()
        {
            List<Jugador> jugadores = serviceJugador.Listar();
            return View(jugadores);
        }

        public ActionResult AgregarJugador()
        {
            
            return View();
        }

        /*
        public ActionResult Guardar(Jugador j)
        {
            serviceJugador.Agregar(j);

            return RedirectToAction("Listado", "Jugador");

        }

        */
        [HttpPost]
        public ActionResult AgregarJugador(Jugador j)
        {
            Jugador nuevoJ;
            if(!String.IsNullOrEmpty (Request["GolesRecibidos"]))
            {
                nuevoJ = new Arquero();
                nuevoJ.Posicion = "Arquero";
                ((Arquero)nuevoJ).GolesRecibidos = Int32.Parse(Request["GolesRecibidos"]);

            }
            else { //Delantero

                nuevoJ = new Delantero();
                int GolesConvertidos = 0;
                nuevoJ.Posicion = "Delantero";
                Int32.TryParse(Request["GolesConvertidos"], out GolesConvertidos);

                ((Delantero)nuevoJ).GolesConvertidos = GolesConvertidos;


            }
            nuevoJ.Nombre = j.Nombre;
            nuevoJ.Edad = j.Edad;
            nuevoJ.Apellido = j.Apellido;
            nuevoJ.Id = j.Id;
            
            serviceJugador.Agregar(nuevoJ);

            return RedirectToAction("Listado", "Jugador");

        }


        /*
        [HttpPost]
        public ActionResult AgregarJugador(Jugador jj)
        {
            Session["UltimoJugadorAgregado"] = jj;
            serviceJugador.Agregar(jj);

            return RedirectToAction("Listado", "Jugador");
        }
        */
        /*
        public ActionResult Eliminar(int id)
        {
            var sj = new JugadorServicio();
            sj.Eliminar(id);

            return RedirectToAction("Listado", "Jugador");
        }*/

        public ActionResult Eliminar(int id)
        {
            Jugador jj = serviceJugador.ObtenerPorId(id);

            TempData["JugEliminado"] = jj;

            serviceJugador.Eliminar(id);
            

            return RedirectToAction("Listado", "Jugador");
        }


        public ActionResult FormEditar( int id)
        {
            Jugador j = serviceJugador.ObtenerPorId(id);
            return View(j);

        }

        public ActionResult Modificar(Jugador j)
        {
            serviceJugador.Modificar(j);


            return RedirectToAction("Listado", "Jugador");

        }       
    }


    
}