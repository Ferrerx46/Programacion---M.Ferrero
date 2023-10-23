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
    public partial class FormDeposito : Form
    {

        public FormDeposito()
        {
            InitializeComponent();
        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtNumeroCuenta.Text;
            decimal monto;
            
            if (decimal.TryParse(txtMonto.Text, out monto))
            {
                if (monto <= 0)
                {
                    MessageBox.Show("Ingrese un número de cuenta válido y un monto mayor que cero.");
                    return;
                }

                string resultado = Principal.RealizarDeposito(numeroCuenta, monto);
                MessageBox.Show(resultado);

                this.Close();
            }
 
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {
            Principal._contexto.CuentasBancarias.Load();


        }
    }
}
