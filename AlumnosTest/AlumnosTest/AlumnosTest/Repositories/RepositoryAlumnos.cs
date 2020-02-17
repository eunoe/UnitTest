using AlumnosTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlumnosTest.Repositories
{
    public class RepositoryAlumnos
    {
        List<Alumno> alumnos;
        public RepositoryAlumnos()
        {
            alumnos = this.GenerarAlumnos();
        }

        public List<Alumno> ListarAlumnos() {
            return alumnos;
        }

        public Alumno GetAlumno(int id)
        {
            return alumnos.Where(x => x.Id == id).FirstOrDefault();
        }

        public int ContarAlumnos() {
            return alumnos.Count();
        }

        public String AlumnoMayor() {
            return alumnos.OrderByDescending(x => x.Edad).FirstOrDefault().Nombre;
        }

        public List<String> GetClases()
        {
            return alumnos.Select(x => x.Clase).Distinct().ToList();
        }

        public List<Alumno> GetAlumnosPorClase(String clase)
        {
            return alumnos.Where(x => x.Clase == clase).ToList();
        }

        private List<Alumno> GenerarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno = new Alumno();
            alumno.Id = 1;
            alumno.Nombre = "Pepe";
            alumno.Apellidos = "González";
            alumno.Edad = 20;
            alumno.Clase = "MCSD";
            alumnos.Add(alumno);

            alumno = new Alumno();
            alumno.Id = 2;
            alumno.Nombre = "Maria";
            alumno.Apellidos = "Pérez";
            alumno.Edad = 25;
            alumno.Clase = "MCSD";
            alumnos.Add(alumno);

            alumno = new Alumno();
            alumno.Id = 3;
            alumno.Nombre = "Marcos";
            alumno.Apellidos = "López";
            alumno.Edad = 17;
            alumno.Clase = "DAM";
            alumnos.Add(alumno);

            alumno = new Alumno();
            alumno.Id = 4;
            alumno.Nombre = "Lorena";
            alumno.Apellidos = "Gomez";
            alumno.Edad = 40;
            alumno.Clase = "DAM";
            alumnos.Add(alumno);

            alumno = new Alumno();
            alumno.Id = 5;
            alumno.Nombre = "Andrea";
            alumno.Apellidos = "Muñoz";
            alumno.Edad = 29;
            alumno.Clase = "DAW";
            alumnos.Add(alumno);

            alumno = new Alumno();
            alumno.Id = 6;
            alumno.Nombre = "Manuel";
            alumno.Apellidos = "Salinas";
            alumno.Edad = 39;
            alumno.Clase = "DAW";
            alumnos.Add(alumno);

            return alumnos;
        }
    }
}