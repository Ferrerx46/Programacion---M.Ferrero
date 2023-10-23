using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    public class CuentaBancaria
    {
        [Key]
        public int CuentaID { get; set; }
        public string? NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string? Tipo { get; set; } // ´´Corriente´´ o ´´Ahorro´´


    }
}
