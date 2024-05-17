using ClassLibrary2;


namespace TestEjercicioB
{
    public class Tests
    {
        [Test]
        public void Test_CalcularSueldo()
        {
            var profesor = new Profesor("Mateo Ferrero", "Profesor GYM");
            profesor.AgregarClase(new Clases("Parte superior", 10, DateTime.Now));
            profesor.AgregarClase(new Clases("Parte inferior", 12, DateTime.Now));

            var calendario = new Calendario(profesor);
            var sueldo = calendario.CalcularSueldo();

            Assert.That(sueldo, Is.EqualTo(110000));
        }

        [Test]
        public void Test_SinAlumnos()
        {
            var profesor = new Profesor("Gabriel Luccine", "Instructor de yoga");
            var clase1 = new Clases("yoga", 0, DateTime.Now);
            var clase2 = new Clases("pilates", 2, DateTime.Now);
            profesor.AgregarClase(clase1);
            profesor.AgregarClase(clase2);

            var calendario = new Calendario(profesor);
            var sinAlumnos = calendario.ClasesSinAlumnos();

            Assert.That(sinAlumnos.Count, Is.EqualTo(1));
            Assert.That(sinAlumnos[0], Is.EqualTo(clase1));
        }

        [Test]
        public void Profesor_sinclases() 
        { 
            var profesor = new Profesor("Hernan Maldonado", "Profesor de educacion fisica");

            Assert.IsNotNull(profesor.clases);
            Assert.That(profesor.clases.Count, Is.EqualTo(0));
        }

        [Test]
        public void AgregarClase()
        {
            var profesor = new Profesor("Carlos Rosales", "Profesor de gym");
            var clase = new Clases("Pecho, espalda y biceps", 14, DateTime.Now);

            profesor.AgregarClase(clase);
            Assert.That(profesor.clases.Count, Is.EqualTo(1));
        }
    }
}