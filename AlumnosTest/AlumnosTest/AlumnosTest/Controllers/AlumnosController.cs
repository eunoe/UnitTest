using AlumnosTest.Models;
using AlumnosTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlumnosTest.Controllers
{
    public class AlumnosController : Controller
    {
        RepositoryAlumnos repos;
        public AlumnosController()
        {
            this.repos = new RepositoryAlumnos();
        }

        // GET: Index
        public ActionResult Index()
        {
            List<Alumno> alumnos = repos.ListarAlumnos();
            ViewBag.TotalAlumnos = repos.ContarAlumnos();
            ViewBag.AlumnoMayor = repos.AlumnoMayor();
            return View(alumnos);
        }

        // GET: Detalles
        public ActionResult Detalles(int id)
        {
            Alumno alumno = repos.GetAlumno(id);
            return View(alumno);
        }

        // GET: Clases
        public ActionResult Clases(String clase)
        {
            List<String> clases = repos.GetClases();
            if (clase != null) {
                ViewBag.Alumnos = repos.GetAlumnosPorClase(clase);
                ViewBag.Clase = clase;
            } 
            return View(clases);
        }

    }
}