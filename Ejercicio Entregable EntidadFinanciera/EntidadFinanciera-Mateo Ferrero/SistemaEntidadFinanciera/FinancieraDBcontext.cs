using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    internal class FinancieraDBcontext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<CuentaBancaria> CuentasBancarias { get; set;}
        public DbSet<TarjetaCredito> TarjetasCredito { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = COMPUT025521\\SQLEXPRESS; database = EntidadFinanciera; trusted_connection = true; Encrypt = False");
        }
    }

   
}
