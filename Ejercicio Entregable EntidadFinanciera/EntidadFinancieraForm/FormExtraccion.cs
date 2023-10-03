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
    public partial class FormExtraccion : Form
    {
        public FormExtraccion()
        {
            InitializeComponent();
        }

        private void buttonExtraer_Click(object sender, EventArgs e)
        {
            int cuentaID;
            decimal monto;

            if (!int.TryParse(txtNumero.Text, out cuentaID) || !decimal.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un número de cuenta válido y un monto mayor que cero.");
                return;
            }

            string resultado = Principal.RealizarExtraccion(cuentaID, monto);
            MessageBox.Show(resultado);

            this.Close();
        }
    }
}
