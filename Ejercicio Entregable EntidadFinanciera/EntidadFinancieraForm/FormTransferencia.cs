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
            int cuentaOrigenNumero;
            int cuentaDestinoNumero;
            decimal monto;

            if (!int.TryParse(txtOrigen.Text, out cuentaOrigenNumero) || !int.TryParse(txtDestino.Text, out cuentaDestinoNumero) || !decimal.TryParse(txtMonto.Text, out monto) || monto <= 0)
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
