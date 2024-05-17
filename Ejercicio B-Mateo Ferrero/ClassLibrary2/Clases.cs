using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Clases
    {
        public string Tema { get; set; }
        public int CantidadAlumnos { get; set; }
        public DateTime FechaInicio { get; set; }

        public Clases(string tema, int cantidadalumnos, DateTime fechainicio)
        {
            Tema = tema;
            CantidadAlumnos = cantidadalumnos;
            FechaInicio = fechainicio;
        }
    }
}
