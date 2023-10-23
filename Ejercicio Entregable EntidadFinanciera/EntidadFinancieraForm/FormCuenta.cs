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
    public partial class FormCuenta : Form
    {

        public FormCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal saldo;
            if (!decimal.TryParse(txtSaldo.Text, out saldo))
            {
                MessageBox.Show("Ingrese un saldo válido.");
                return;
            }
            string tipo = cboTipoCuenta.SelectedItem.ToString();
            int dniCliente;
            if (!int.TryParse(txtDNI.Text, out dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            Principal.CrearCuentaBancaria(saldo, tipo, dniCliente);
            MessageBox.Show("La cuenta ha sido creada con exito", "Exito");

        }

        private void FormCuenta_Load(object sender, EventArgs e)
        {
            Principal._contexto.CuentasBancarias.Load();
            dataGridViewCuentas.DataSource = null;
            dataGridViewCuentas.DataSource = Principal._contexto.CuentasBancarias.Local.ToBindingList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtNumero.Text;
            string resultado = Principal.EliminarCuenta(numeroCuenta);
            MessageBox.Show(resultado);
        }
    }
}
