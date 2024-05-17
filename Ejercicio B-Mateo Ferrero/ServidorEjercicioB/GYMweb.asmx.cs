using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServidorEjercicioB
{
    /// <summary>
    /// Descripción breve de GYMweb
    /// </summary>
    [WebService(Namespace = "http://Gimnacio.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class GYMweb : WebService
    {

        private static Profesor profesor = new Profesor("Mateo Ferrero", "Instructor de GYM");

        [WebMethod]
        public void AgregarClase(string tema, int cantidadGente, DateTime fecha)
        {
            var clase = new Clases(tema, cantidadGente, fecha);
            profesor.AgregarClase(clase);
        }

        [WebMethod]
        public List<string> sinAlumnos()
        {
            var calendario = new Calendario(profesor);
            var sinAlumnos = calendario.ClasesSinAlumnos();
            return sinAlumnos.Select(c => c.Tema).ToList();
        }

        [WebMethod]
        public double CalcularSueldo()
        {
            var calendario = new Calendario(profesor);
            return calendario.CalcularSueldo();
        }

        [WebMethod]
        public List<string> ObtenerClase()
        {
            return profesor.clases.Select(c => c.Tema).ToList();
        }
    }
}
