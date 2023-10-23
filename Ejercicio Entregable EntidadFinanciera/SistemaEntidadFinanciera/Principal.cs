using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaEntidadFinanciera
{
    public class Principal
    {
        public static FinancieraDBcontext  _contexto = new FinancieraDBcontext();
     
        public static void AgregarCliente(string nombre, string apellido, int dni)
        {
            Cliente ClienteNuevo = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni
            };

            _contexto.Clientes.Add(ClienteNuevo);
            _contexto.SaveChanges();

        }

        public static string EliminarCliente(int dni)
        {
            Cliente? cliente = _contexto.Clientes.First<Cliente>(x => x.DNI == dni);

            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                _contexto.SaveChanges();

                return "Cliente eliminado con exito";
            }
            else
            {
                return "Cliente no encontrada";
            }
        }

        public static void CrearCuentaBancaria(decimal saldo, string tipo, int dni)
        {
            string numeroCuenta = GenerarNumeroCuenta(tipo, dni);

            CuentaBancaria nuevaCuenta = new CuentaBancaria
            {
                NumeroCuenta = numeroCuenta,
                Saldo = saldo,
                Tipo = tipo
            };

            _contexto.CuentasBancarias.Add(nuevaCuenta);
            _contexto.SaveChanges();
        }

        private static string GenerarNumeroCuenta(string tipo, int dni)
        {
            Random random = new Random();
            //string numeroCuenta = CuentaAhorro ? "00" : "01"; 
            string numeroCuenta;
            string randomV = "";
            for (int i = 0; i < 12; i++)
            {
                randomV += random.Next(0, 9).ToString();
            }

            if (tipo == "Ahorro")
            {
                numeroCuenta = ("00" + dni.ToString() + randomV);
            }
            else
            {
                numeroCuenta = ("01" + dni.ToString() + randomV);
            }
            return numeroCuenta;
        }

        public static string EliminarCuenta(string numeroCuenta)
        {
            CuentaBancaria? cuenta = _contexto.CuentasBancarias.FirstOrDefault<CuentaBancaria>(x => x.NumeroCuenta == numeroCuenta);

            if (cuenta != null)
            {
                _contexto.CuentasBancarias.Remove(cuenta);
                _contexto.SaveChanges();

                return "Cuenta eliminada con exito";
            }
            else
            {
                return "Cuenta no encontrada";
            }
        }

        public static string EmitirTarjetaCredito(int dni, decimal limiteCredito)
        {
            string numeroTarjeta = GenerarNumeroTarjeta(dni);
            TarjetaCredito tarjetaNueva = new TarjetaCredito
            {
               NumeroTarjeta = numeroTarjeta,
               LimiteCredito = limiteCredito,
               SaldoDisponible = limiteCredito,
               Estado = "Activa"
            };
            _contexto.TarjetasCredito.Add(tarjetaNueva);
            _contexto.SaveChanges();
            return "Tarjeta de crédito emitida con éxito.";
        }
        public static string GenerarNumeroTarjeta(int dni)
        {
            Random random = new Random();
            string numeroTarjeta = "4" + dni.ToString("D11");

            for (int i = 0; i < 4; i++) 
            {
                numeroTarjeta += random.Next(0, 10).ToString();
            }
            return numeroTarjeta;
        }

        public static string PausarTarjetaCredito(string numeroTarjeta)
        {
            TarjetaCredito? tarjeta = _contexto.TarjetasCredito.First<TarjetaCredito>(x => x.NumeroTarjeta == numeroTarjeta);

            if (tarjeta != null)
            {
                if (tarjeta.Estado == "Activa")
                {
                    tarjeta.Estado = "Pausada";
                    _contexto.SaveChanges();
                    return "Se ha pasusado ";
                }
                else
                {
                    return ("La tarjeta de crédito ya está pausada o bloqueada.");
                }
            }
            else
            {
                return "Tarjeta de crédito no encontrada.";
            }
        }

        public static string RealizarDeposito(string numeroCuenta, decimal monto)
        {

            //CuentaBancaria? cuenta = _contexto.CuentasBancarias.Where(x => x.NumeroCuenta == numeroCuenta) as CuentaBancaria;
            CuentaBancaria? cuenta = _contexto.CuentasBancarias.FirstOrDefault<CuentaBancaria>(x => x.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
            {
                cuenta.Saldo += monto;
                _contexto.SaveChanges();
                return "Se realizo el deposito";
            }
            else
            {
                return "Cuenta no encontrada";
            };
        }

        public static string RealizarExtraccion(string numeroCuenta, decimal monto)
        {
            CuentaBancaria? cuenta = _contexto.CuentasBancarias.FirstOrDefault<CuentaBancaria>(x => x.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
            {
                if (cuenta.Saldo >= monto)
                {
                    cuenta.Saldo -= monto;
                    _contexto.SaveChanges();
                    return "Estraccion realizada con exito";
                }
                else
                {
                    return "Saldo insuficiente para retirar";
                }
            }
            else
            {
                return "Cuenta no encontrada";
            }

        }
        
        public static string RealizarTransferencia(string cuentaOrigenNumero, string cuentaDestinoNumero, decimal monto)
        {
            CuentaBancaria? cuentaOrigen = _contexto.CuentasBancarias.FirstOrDefault<CuentaBancaria>(x => x.NumeroCuenta == cuentaOrigenNumero);
            CuentaBancaria? cuentaDestino = _contexto.CuentasBancarias.FirstOrDefault<CuentaBancaria>(x => x.NumeroCuenta == cuentaDestinoNumero);

            if (cuentaOrigen != null && cuentaDestino != null)
            {
                if (cuentaOrigen.Saldo >= monto)
                {
                    cuentaOrigen.Saldo -= monto;
                    cuentaDestino.Saldo += monto;
                    _contexto.SaveChanges();
                    return "Transferencia realizada con exito";
                }
                else
                { 
                    return "Saldo insuficiente para realizar la transaccion";
                }
            }
            else
            {
                 return "Cuenta no encontrada"; 
            }
        }

       public static string PagarTarjetaCredito(string numeroTarjeta, decimal MontoPago)
       {
            TarjetaCredito? tarjeta = _contexto.TarjetasCredito.First<TarjetaCredito>(x => x.NumeroTarjeta == numeroTarjeta);

            if (tarjeta != null)
            {
                if (MontoPago <= 0)
                {
                    return "El monto del pago debe ser mayor que cero.";
                }
                else if (MontoPago > tarjeta.MontoDeuda)
                {
                    return "El monto del pago no puede superar la deuda actual.";
                }
                else
                {
                    tarjeta.SaldoDisponible += MontoPago;
                    tarjeta.MontoDeuda -= MontoPago;
                    _contexto .SaveChanges();
                    return "Se realizo el pago";
                }
            }
            else 
            {
                return "Tarjeta de crédito no encontrada.";
            }

       }

        public static string GenerarResumen(string numeroTarjeta)
        {
            TarjetaCredito? tarjeta = _contexto.TarjetasCredito.First<TarjetaCredito>(x => x.NumeroTarjeta == numeroTarjeta);
            if (tarjeta != null)
            {
                StringBuilder ret =  new StringBuilder();

                ret.AppendLine("Resumen de la tarjeta");
                ret.AppendLine("Numero de la tarjeta: " + tarjeta.NumeroTarjeta);
                ret.AppendLine("Limite de credito: " + tarjeta.LimiteCredito);
                ret.AppendLine("Saldo disponible: " + tarjeta.SaldoDisponible);
                ret.AppendLine("El estado es: " + tarjeta.Estado);
                ret.AppendLine("La deuda es de: " + tarjeta.MontoDeuda);

                return ret.ToString();
            }
            return "Error";
        }
        public List<TarjetaCredito>ListaRetornarTarjeta()
        {
            return _contexto.TarjetasCredito.ToList();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}


