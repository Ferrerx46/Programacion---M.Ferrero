using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEntidadFinanciera
{
    public class Principal
    {
        private FinancieraDBcontext _contexto;

        public Principal()
        {
            _contexto = new FinancieraDBcontext();
        }
        public void AgregarCliente(string nombre, string apellido, string dni)
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

        public void CrearCuentaBancaria(int clienteId, string numeroCuenta, decimal saldo, string tipo)
        {
            Cliente cliente = _contexto.Clientes.Find(clienteId);
            if (cliente != null)
            {
                CuentaBancaria nuevaCuenta = new CuentaBancaria
                {
                    NumeroCuenta = numeroCuenta,
                    Saldo = saldo,
                    Tipo = tipo
                };

                cliente.CuentasBancarias.Add(nuevaCuenta);
                _contexto.SaveChanges();

            }
            else
            {
                Console.WriteLine("Cliente no Encontrado");
            }

        }

        public void EmitirTarjetaCredito(int clienteId, string numeroTarjeta, decimal limiteCredito)
        {
            Cliente cliente = _contexto.Clientes.Find(clienteId);

            if (cliente != null)
            {
                TarjetaCredito TarjetaNueva = new TarjetaCredito
                {
                    NumeroTarjeta = numeroTarjeta,
                    LimiteCredito = limiteCredito,
                    SaldoDisponible = limiteCredito,
                    Estado = "Activa"
                };

                cliente.TarjetasCredito.Add(TarjetaNueva);
                _contexto.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
        }
        public void PausarTarjetaCredito(int tarjetaId)
        {
            TarjetaCredito tarjeta = _contexto.TarjetasCredito.Find(tarjetaId);

            if (tarjeta != null)
            {
                if (tarjeta.Estado == "Activa")
                {
                    tarjeta.Estado = "Pausada";
                    _contexto.SaveChanges();
                }
                else
                {
                    Console.WriteLine("La tarjeta de crédito ya está pausada o bloqueada.");
                }
            }
            else
            {
                Console.WriteLine("Tarjeta de crédito no encontrada.");
            }
        }

        public void RealizarDeposito(int cuentaID, decimal monto)
        {
            CuentaBancaria cuenta = _contexto.CuentasBancarias.Find(cuentaID);

            if (cuenta != null)
            {
                cuenta.Saldo += monto;
                _contexto.SaveChanges();
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada");
            };
        }

        public void RealizarEstraccion(int cuentaID, decimal monto)
        {
            CuentaBancaria cuenta = _contexto.CuentasBancarias.Find(cuentaID);
            if (cuenta != null)
            {
                if (cuenta.Saldo >= monto)
                {
                    cuenta.Saldo -= monto;
                    _contexto.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para retirar");
                }
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada");
            }

        }
        public void RealizarTransferencia(int CuentaOrigenID, int CuentaDestinoID, decimal monto)
        {
            CuentaBancaria CuentaOrigen = _contexto.CuentasBancarias.Find(CuentaOrigenID);
            CuentaBancaria CuentaDestino = _contexto.CuentasBancarias.Find(CuentaDestinoID);

            if (CuentaOrigen != null && CuentaDestino != null) 
            {
                if (CuentaOrigen.Saldo >= monto)
                {
                    CuentaOrigen.Saldo -= monto;
                   CuentaDestino.Saldo += monto;
                    _contexto.SaveChanges();
                }
                else 
                { 
                    Console.WriteLine("Saldo insuficiente para realizar la transaccion"); 
                }
            }

        }

       public void PagarTarjetaCredito(int TarjetaID, decimal MontoPago)
       {
            TarjetaCredito tarjeta = _contexto.TarjetasCredito.Find(TarjetaID);

            if (tarjeta != null)
            {
                if (MontoPago <= 0)
                {
                    Console.WriteLine("El monto a pagar debe ser mayor a 0");
                }
                else if (MontoPago > tarjeta.MontoDeuda)
                {
                    Console.WriteLine("El monto de pago no puede superar la deuda");
                }
                else
                {
                    tarjeta.SaldoDisponible += MontoPago;
                    tarjeta.MontoDeuda -= MontoPago;
                    _contexto .SaveChanges();
                }
            }
            else 
            { 
                Console.WriteLine("Tarjeta no encontrada"); 
            }

       }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}


