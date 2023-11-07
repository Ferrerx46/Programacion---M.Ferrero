using Microsoft.EntityFrameworkCore;
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
            int dniCliente;
            decimal limiteCredito;

            if (!int.TryParse(txtDNI.Text, out dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                
            }
            if (decimal.TryParse(txtLimite.Text, out limiteCredito)!)
            {
                MessageBox.Show("Ingrese valores válidos para el número de tarjeta y el límite de crédito.");
                
            }

            string resultado = Principal.EmitirTarjetaCredito(dniCliente, limiteCredito);
            MessageBox.Show(resultado);
        }

        private void buttonPausar_Click(object sender, EventArgs e)
        {




            string resultado = Principal.PausarTarjetaCredito(txtNumeroTarjeta.Text);
            MessageBox.Show(resultado);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            string numeroTarjeta = txtNumeroTarjeta.Text;
            decimal montoPago;

            if (!decimal.TryParse(txtMonto.Text, out montoPago))
            {
                MessageBox.Show("Ingrese valores validos para el numero de tarjeta y el monto.");
                return;
            }

            string resultado = Principal.PagarTarjetaCredito(numeroTarjeta, montoPago);
            MessageBox.Show(resultado);
        }

        private void buttonResumen_Click(object sender, EventArgs e)
        {

            string resumen = Principal.GenerarResumen(txtNumeroTarjeta.Text);

            if (resumen != "Tarjeta no encontrada")
            {
                MessageBox.Show(resumen, "Resumen de Tarjeta de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tarjeta de crédito no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTarjeta_Load(object sender, EventArgs e)
        {
            Principal._contexto.TarjetasCredito.Load();
            dataGridViewCuentas.DataSource = null;
            dataGridViewCuentas.DataSource = Principal._contexto.TarjetasCredito.Local.ToBindingList();
        }
    }
}
