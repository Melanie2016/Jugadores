using JugadoresCRUD.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JugadoresCRUD.Controllers
{
    public class JugadorController : Controller
    {

        EquipoServico serviceEquipo = new EquipoServico();
        JugadorServicio serviceJugador = new JugadorServicio();

        // GET: Jugador
        public ActionResult Listado()

        {
            List<jugador> jugadores = serviceJugador.Listar();
            return View(jugadores);
        }

        public ActionResult AgregarJugador()
        {
            ViewBag.ListaEquipo = serviceEquipo.ObtenerTodos();
            return View();
        }

        [HttpPost]
        public ActionResult AgregarJugador(jugador j)
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
       

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            jugador j = serviceJugador.ObtenerPorId(id);
            return View(j);

        }

        [HttpPost]
        public ActionResult Modificar(jugador j)
        {
            serviceJugador.Modificar(j);

            return RedirectToAction("Listado", "Jugador");

        }   
        


    }


    
}