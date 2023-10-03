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
            int numeroCuenta;
            decimal saldo;

            if (!int.TryParse(txtNumeroCuenta.Text, out numeroCuenta) || !decimal.TryParse(txtSaldo.Text, out saldo))
            {
                MessageBox.Show("Ingrese un numero de cuenta y saldo validos");
                return;
            }
            string tipo = cboTipoCuenta.SelectedItem.ToString();

            Principal.CrearCuentaBancaria(numeroCuenta, saldo, tipo);
            MessageBox.Show("Cuenta creada con exito");

            this.Close();
        }
    }
}
