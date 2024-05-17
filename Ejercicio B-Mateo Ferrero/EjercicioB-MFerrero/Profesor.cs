namespace EjercicioB_MFerrero
{
    public class Profesor
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string Titulo { get; set; }
        public List<Clases> clases { get; set; }

        public Profesor(string nombre, string titulo) 
        {
            Nombre = nombre;
            Titulo = titulo;
            clases = new List<Clases>();
        }

        public void AgregarClase(Clases clase)
        {
            clases.Add(clase);
        }
    }
}
