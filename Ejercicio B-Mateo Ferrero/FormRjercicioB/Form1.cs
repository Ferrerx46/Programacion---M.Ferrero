using ServidorEjercicioB;

namespace FormRjercicioB
{
    public partial class Form1 : Form
    {
        private GYMweb servicio;

        public Form1()
        {
            InitializeComponent();
            servicio = new GYMweb();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string tema = textBoxTema.Text;
            int cantidadAlumnos = int.Parse(textBoxAlumnos.Text);
            DateTime inicio = dateTimePicker1.Value;

            servicio.AgregarClase(tema, cantidadAlumnos, inicio);
            listboxClases.Items.Add($"{tema} - {cantidadAlumnos} estudiantes - {inicio.ToShortDateString()}");
        }

        private void buttonSueldo_Click(object sender, EventArgs e)
        {
            double sueldo = servicio.CalcularSueldo();
            MessageBox.Show("El sueldo calculado es: " + sueldo.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sinalumnos = servicio.sinAlumnos();
            listboxClases.Items.Clear();
            foreach ( var clase in sinalumnos ) 
            {
                listboxClases.Items.Add(clase);
            }
        }
    }
}
