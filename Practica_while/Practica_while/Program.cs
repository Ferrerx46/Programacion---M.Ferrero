internal class Program
{
    private static void Main(string[] args)
    {
        // Ejercicio 1
        /*
        int numero = 1;
        int suma = 0;
        while (numero != 0)
        {
            Console.WriteLine("Ingrese un valor positivo o un 0 para finalizar.");
            numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                suma += numero;
            }
        }
        Console.WriteLine("La suma de los numeros ingresados es: " + suma);
        */

        // Ejercicio 2
        /*
        int numero = 1;
        int suma = 0;
        int promedio = 0;
        while (numero != 0)
        {
            Console.WriteLine("Ingrese un valor positivo o un 0 para finalizar.");
            numero = int.Parse(Console.ReadLine());
            
            if (numero > 0)
            {
                suma += numero;
                numero++;
                promedio = suma / numero;
            }
        }
        Console.WriteLine("La suma de los numeros ingresados es: " + suma);
        Console.WriteLine(promedio);
        */

        // Ejercicio 3
        /*
        string nombre = "";
        int contador = 0;
        while (nombre != null && nombre != "")
        {
            Console.WriteLine("Ingrese el nombre.");
            nombre = Console.ReadLine();
            if (nombre != null && nombre != "")
            { 
                 contador++; 
            }
        }
        Console.WriteLine("Se ingresaron los siguientes nombres: " + contador);
        */

        // Ejercicio 4
        /*
        int deuda = 0;
        int costo = 1;
        while (costo != 0)
        {
            Console.WriteLine("Ingrese el costo: ");
            costo = int.Parse(Console.ReadLine());
            if (costo != 0)
            {
                Console.WriteLine("Ingrese el total: ");
                int total = int.Parse(Console.ReadLine());
                deuda += total;
            }
        }
        
        Console.WriteLine("El total es: " + deuda);
        */

        // Ejercicio 5

        Console.WriteLine("Ingrese la cantidad de productos. ");
        int productos = int.Parse(Console.ReadLine());
        int total_pagar = 0;
        int contador = 1;
        
        while (contador <= productos)
        {
            Console.WriteLine("Producto N°: ");
            Console.WriteLine("Ingrese el total: ");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo: ");
            int costo = int.Parse(Console.ReadLine());
            total_pagar = total - costo;
            contador++;
        }
        Console.WriteLine("El total a pagar de el cliente es: " + total_pagar);
    }
}