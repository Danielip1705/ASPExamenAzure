using ASPExamenPrueba.Models;
using ASPExamenPrueba.Models.VM;
using BL;
using ENT;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPExamenPrueba.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Accion que muestra una lista de misiones en la vista principal
        /// </summary>
        /// <returns>View model con la lista de misiones y de candidatos</returns>
        public IActionResult Index()
        {
            ListadoCandidatosMisionesVM vm = new ListadoCandidatosMisionesVM
            {
                misiones = ListadoMisionesBL.getListadoMisionesBL()
            };
            return View(vm);
        }

        /// <summary>
        /// Accion Post que recoge la dificultad de la mision elegida y devuelve los candidatos para esa mision
        /// </summary>
        /// <param name="dificultad">Numero entero que indica la dificultad de la mision</param>
        /// <returns>View model con la lista de misiones y de candidatos</returns>
        [HttpPost]
        public IActionResult Index(int dificultad)
        {
            List<Candidato> listaCandidatos = ListadoCandidatosBL.getListadoCandidatosAptoBL(dificultad);
            ListadoCandidatosMisionesVM vm = new ListadoCandidatosMisionesVM
            {
                misiones = ListadoMisionesBL.getListadoMisionesBL(),
                candidatos = ListadoCandidatosBL.getListadoCandidatosAptoBL(dificultad)
            };

            return View(vm);
        }
        /// <summary>
        /// Accion get que recoge el id del candidato y lo muestra en otra vista
        /// </summary>
        /// <param name="id">Numero entero que indica </param>
        /// <returns>Lista de candidatos</returns>
        [HttpGet]
        public IActionResult CandidatoDetails(int id)
        {
            Candidato candidato = ListadoCandidatosBL.getCandidatoPorIdBL(id);
            return View(candidato);
        }
    }
}
