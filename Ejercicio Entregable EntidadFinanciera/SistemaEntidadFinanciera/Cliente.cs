using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    public class Cliente
    {
        //[Key]
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set;}
        public int DNI { get; set;}

    }
}
