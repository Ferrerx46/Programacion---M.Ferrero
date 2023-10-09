using SistemaEntidadFinanciera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntidadFinancieraForm
{
    public partial class FormTarjeta : Form
    {
        public FormTarjeta()
        {
            InitializeComponent();
        }

        private void buttonEmitir_Click(object sender, EventArgs e)
        {
            int numeroTarjeta;
            decimal limiteCredito;

            if (int.TryParse(txtNumero.Text, out numeroTarjeta) || !decimal.TryParse(txtLimite.Text, out limiteCredito))
            {
                MessageBox.Show("Ingrese valores válidos para el número de tarjeta y el límite de crédito.");
                return;
            }

            string resultado = Principal.EmitirTarjetaCredito(numeroTarjeta, limiteCredito);
            MessageBox.Show(resultado);
        }

        private void buttonPausar_Click(object sender, EventArgs e)
        {
            int numeroTarjeta;

            if (!int.TryParse(txtNumero.Text, out numeroTarjeta))
            {
                MessageBox.Show("Ingrese un numero de tarjeta valida.");
                return;
            }

            string resultado = Principal.PausarTarjetaCredito(numeroTarjeta);
            MessageBox.Show(resultado);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            int numeroTarjeta;
            decimal montoPago;

            if (int.TryParse(txtNumero.Text, out numeroTarjeta) || !decimal.TryParse(txtMonto.Text, out montoPago))
            {
                MessageBox.Show("Ingrese valores validos para el numero de tarjeta y el monto.");
                return;
            }

            string resultado = Principal.PagarTarjetaCredito(numeroTarjeta,montoPago);
            MessageBox.Show(resultado);
        }

        private void buttonResumen_Click(object sender, EventArgs e)
        {
            int tarjetaCreditoID;

            if (!int.TryParse(txtNumero.Text, out tarjetaCreditoID))
            {
                MessageBox.Show("Ingrese un número de tarjeta válido.");
                return;
            }

            string resumen = Principal.GenerarResumen(tarjetaCreditoID);

            if (resumen != "Tarjeta no encontrada")
            {
                MessageBox.Show(resumen, "Resumen de Tarjeta de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tarjeta de crédito no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
