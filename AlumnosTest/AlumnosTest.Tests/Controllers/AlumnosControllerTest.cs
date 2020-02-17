using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using AlumnosTest.Controllers;
using AlumnosTest.Models;
using AlumnosTest.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlumnosTest.Tests.Controllers
{
    [TestClass]
    public class AlumnosControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Instanciamos el controlador
            AlumnosController controller = new AlumnosController();
            
            //Instanciamos los valores que queremos comprobar
            ViewResult result = controller.Index() as ViewResult;
            int totalalumnos = result.ViewBag.TotalAlumnos;
            String alumnomayor = result.ViewBag.AlumnoMayor;

            //Comprobamos que el controlador devulve datos a la vista
            Assert.IsNotNull(result);

            //Comprobamos si se cumple una condicion
            Assert.IsTrue(totalalumnos > 0, "No hay alumnos registrados");

            //Comprobamos si dos valores son iguales
            Assert.AreEqual("Lorena", alumnomayor);
        } 
        
        [TestMethod]
        public void Detalles()
        {
            //Instanciamos el controlador
            AlumnosController controller = new AlumnosController();

            //Instanciamos los valores que queremos comprobar
            ViewResult result = controller.Detalles(1) as ViewResult;

            //Comprobamos si el controlador devuelve un objeto de tipo alumno
            Assert.IsInstanceOfType(result.Model, typeof(Alumno));
        }
        
        [TestMethod]
        public void Clases()
        {
            //Instanciamos el controlador
            AlumnosController controller = new AlumnosController();

            //Instanciamos los valores que queremos comprobar
            //1): Ejecucion sin pasar parametros
            ViewResult result1 = controller.Clases(null) as ViewResult;

            //Comprobamos si el controlador devuelve datos a la vista
            Assert.IsNotNull(result1);
            //Comprobamos que ViewBag.Alumnos es nulo
            Assert.IsNull(result1.ViewBag.Alumnos);

            //2): Pasando por parametro MCSD
            ViewResult result2 = controller.Clases("MCSD") as ViewResult;

            //Comprobamos si el controlador devuelve datos a la vista
            Assert.IsNotNull(result2);
            //Comprobamos que ViewBag.Alumnos es de tipo List<Alumno>
            Assert.IsInstanceOfType(result2.ViewBag.Alumnos, typeof(List<Alumno>));
            //Comprobamos que es falso que la longitud de clase es menor o igual a 0
            Assert.IsFalse(result2.ViewBag.Clase.Length <= 0);
        }
    }
}
