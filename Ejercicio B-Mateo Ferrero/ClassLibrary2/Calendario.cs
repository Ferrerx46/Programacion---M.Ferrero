using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Calendario
    {
        public Profesor Profesor { get; set; }

        public Calendario(Profesor profesor)
        {
            Profesor = profesor;
        }

        public double CalcularSueldo()
        {
            int totalAlumnos = Profesor.clases.Sum(c => c.CantidadAlumnos);
            return totalAlumnos * 5000;
        }

        public List<Clases> ClasesSinAlumnos()
        {
            return Profesor.clases.Where(c => c.CantidadAlumnos == 0).ToList();
        }
    }
}
