using System;
using System.Collections.Generic;
using System.Linq;
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
                ID= 2,
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni
            };

            _contexto.Clientes.Add(ClienteNuevo);
            _contexto.SaveChanges();

        }

        public static void CrearCuentaBancaria( int numeroCuenta, decimal saldo, string tipo)
        {
            {
                CuentaBancaria nuevaCuenta = new CuentaBancaria
                { 
                    NumeroCuenta = numeroCuenta,
                    Saldo = saldo,
                    Tipo = tipo
                };
                   
                _contexto.CuentasBancarias.Add(nuevaCuenta);
                _contexto.SaveChanges();
            }
        }

        public static string EmitirTarjetaCredito(int clienteId, int numeroTarjeta, decimal limiteCredito)
        {
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

        public static string PausarTarjetaCredito(int tarjetaId)
        {
            TarjetaCredito? tarjeta = _contexto.TarjetasCredito.Find(tarjetaId);

            if (tarjeta != null)
            {
                if (tarjeta.Estado == "Activa")
                {
                    tarjeta.Estado = "Pausada";
                    _contexto.SaveChanges();
                    return "SE ha pasusado ";
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

        public static string RealizarDeposito(int cuentaID, decimal monto)
        {
            CuentaBancaria? cuenta = _contexto.CuentasBancarias.Find(cuentaID);

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

        public static string RealizarExtraccion(int cuentaID, decimal monto)
        {
            CuentaBancaria? cuenta = _contexto.CuentasBancarias.Find(cuentaID);
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
        
        public static string RealizarTransferencia(int CuentaOrigenID, int CuentaDestinoID, decimal monto)
        {
            CuentaBancaria? CuentaOrigen = _contexto.CuentasBancarias.Find(CuentaOrigenID);
            CuentaBancaria? CuentaDestino = _contexto.CuentasBancarias.Find(CuentaDestinoID);

            if (CuentaOrigen != null && CuentaDestino != null)
            {
                if (CuentaOrigen.Saldo >= monto)
                {
                    CuentaOrigen.Saldo -= monto;
                    CuentaDestino.Saldo += monto;
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
                 return "La cuenta no a sido encontrada"; 
            }
        }

       public static string PagarTarjetaCredito(int TarjetaID, decimal MontoPago)
       {
            TarjetaCredito? tarjeta = _contexto.TarjetasCredito.Find(TarjetaID);

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

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}


