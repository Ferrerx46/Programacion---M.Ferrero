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
    public partial class FormTransferencia : Form
    {

        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            string cuentaOrigenNumero = txtOrigen.Text;
            string cuentaDestinoNumero = txtDestino.Text;
            decimal monto;

            if (decimal.TryParse(txtMonto.Text, out monto))
            {
                if (monto <= 0)
                {
                    MessageBox.Show("Ingrese números de cuenta válidos y un monto mayor que cero.");
                    return;
                }

                string resultado = Principal.RealizarTransferencia(cuentaOrigenNumero, cuentaDestinoNumero, monto);
                MessageBox.Show(resultado);

                this.Close();
            }
 
        }
    }
}
