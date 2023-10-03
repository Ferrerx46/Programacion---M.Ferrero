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
    public partial class FormCliente : Form
    {

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni;

            if (!int.TryParse(txtDNI.Text, out dni))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            Principal.AgregarCliente(nombre, apellido, dni);
            MessageBox.Show("Cliente agregado con éxito.");

            this.Close();
        }
    }
}
