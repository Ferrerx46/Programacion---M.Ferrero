using SistemaEntidadFinanciera;

namespace EntidadFinancieraForm
{
    public partial class EntidadFinancieraform : Form
    {
      

        public EntidadFinancieraform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente form2 = new FormCliente();
            form2.Show();
        }

        private void buttonCuenta_Click(object sender, EventArgs e)
        {
            FormCuenta form1 = new FormCuenta();
            form1.Show();
        }

        private void buttonTarjeta_Click(object sender, EventArgs e)
        {
            FormTarjeta form1 = new FormTarjeta();
            form1.Show();
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            FormOperaciones form1 = new FormOperaciones();
            form1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}