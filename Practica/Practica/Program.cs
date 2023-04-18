using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Hola, me das tu año de nacimiento? ");
        string? Año_nac = Console.ReadLine();
        int Año_final = int.Parse(Año_nac);
        int Año_actual = DateTime.Today.Year;

        int edad = Año_actual - Año_final;

        Console.WriteLine("Vos tenes o vas a cumplir este año: " + edad);
        
        /*
        int suma = 0;
        

        string? valor = Console.ReadLine();
        int valorint = int.Parse(valor);

        while (valorint > 0)
        {
            suma = suma + valorint;
            Console.WriteLine("Ingrese valor:");
            valor = Console.ReadLine();
            valorint = int.Parse(valor);
        }
        Console.WriteLine("Vendiste: " + suma);
        */
    }
}