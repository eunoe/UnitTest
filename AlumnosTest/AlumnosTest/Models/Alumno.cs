using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlumnosTest.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public String Clase { get; set; }
    }
}