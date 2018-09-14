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

        public ActionResult Guardar(Jugador j)
        {
            serviceJugador.Agregar(j);

            return RedirectToAction("Listado", "Jugador");

        }


        public ActionResult Eliminar(int id)
        {
            var sj = new JugadorServicio();
            sj.Eliminar(id);

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