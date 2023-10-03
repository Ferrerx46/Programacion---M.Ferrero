using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    public  class FinancieraDBcontext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<CuentaBancaria> CuentasBancarias { get; set;}
        public DbSet<TarjetaCredito> TarjetasCredito { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = LAPTOP-TI84IK3Q\\SQLEXPRESS; database = EntidadFinanciera; trusted_connection = true; Encrypt = False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                ID = 1,
                Nombre = "Mateo",
                Apellido = "Ferrero",
                DNI = 454545
            });
            base.OnModelCreating(modelBuilder);
        }
    }

   

   
}
