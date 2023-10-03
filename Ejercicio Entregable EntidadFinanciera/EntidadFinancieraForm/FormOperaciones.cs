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
    public partial class FormOperaciones : Form
    {
        public FormOperaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDeposito formDeposito = new FormDeposito();
            formDeposito.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormExtraccion formExtraccion = new FormExtraccion();
            formExtraccion.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTransferencia formTransferencia = new FormTransferencia();
            formTransferencia.Show();
            Close();
        }
    }
}
