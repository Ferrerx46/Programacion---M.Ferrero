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
    public partial class FormCliente : Form
    {

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Principal._contexto.Clientes.Load();
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = Principal._contexto.Clientes.Local.ToBindingList();
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDNI.Text, out int dni)) 
            {
                string resultado = Principal.EliminarCliente(dni); 

                MessageBox.Show(resultado); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido."); 
            }
        }
    }
}
