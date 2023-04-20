internal class Program
{
    private static void Main(string[] args)
    {
        // Ejercicio 1
        /*
        int suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese el número entero " + i);
            int numero = int.Parse(Console.ReadLine());
            suma += numero;
        }
        Console.WriteLine("La suma de los 5 números enteros es: " + suma);
        */

        // Ejercicio 2
        /*
        int suma = 0;
        int promedio;
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine("Ingrese el número " + i + ":");
            int num = int.Parse(Console.ReadLine());
            suma += num;
        }
        promedio = suma / 8;
        Console.WriteLine("El promedio de los 8 números es: " + promedio);
        */

        // Ejercicio 3
        /*
        double total = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese el costo de la compra: " + i);
            double costo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total pagado de la compra: " + i);
            double pagado = double.Parse(Console.ReadLine());
            double adeudado = costo - pagado;
            total =+ adeudado;
        }
        Console.WriteLine("El total adeudado es: " + total);
        */

        // Ejercicio 4
        /*
        int numeros;
        int max = 0;
        for (int i = 0; i <= 8; i++)
        {
            Console.WriteLine("Ingrese los numeros: " + i);
            numeros = int.Parse(Console.ReadLine());
            if (numeros > max)
            {
                max = numeros;
            }
        }
        Console.WriteLine("El mayor numero es: " + max);
        */

        // Ejercicio 5

        string cliente;
        int total;
        int mayor = 0;
        string cliente_mayor = "";
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese el nombre del cliente: " + i);
            cliente = Console.ReadLine();
            Console.WriteLine("Ingrese el total gastado del cliente");
            total = int.Parse(Console.ReadLine());
            if (total > mayor)
            {
                mayor = total;
                cliente_mayor = cliente;
            }
        }
        Console.WriteLine("El cliente que mas gasto es " + cliente_mayor + " con un total de: " + mayor);
    }
}