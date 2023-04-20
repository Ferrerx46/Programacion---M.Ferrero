using System;

NewMethod();

static void NewMethod()
{
    // Ejercicio 1
    /*
    Console.WriteLine("Ingrese la clave");
    string? clave;

    do
    {
        clave = Console.ReadLine();
    } while (clave != "667788");
    
    Console.WriteLine("Contraseña correcta");
    */

    // Ejercicio 2
    /*
    int numero;
     
    do
    {
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        
    } while (numero <= 0);
    
    Console.WriteLine("El numero ingresado es: " + numero);
    */
    
    // Ejercicio 3
    
    int numero;
    int negativos = 0;
    int sumaneg = 0;
    int promedio = 0;
    do
    {
        Console.Write("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero < 0) ;
        {
            negativos++;
            sumaneg += numero;
        }
    } while (numero != 0);
    
    if (negativos > 0)
    {
        promedio = sumaneg / negativos;
    }

    Console.WriteLine("El numero ingresado es: " + numero);
    Console.WriteLine("Su promedio es: " + promedio);
    */

    // Ejercicio 4
    /*
     int numero2;
     do
     {
         Console.WriteLine("Ingrese un numero");
         numero2 = int.Parse(Console.ReadLine());
     } while (numero2 <= 99);

     Console.WriteLine("El numero ingresado es: " + numero2);
     */
    
    //Ejercicio 5
    /*
    int numero2;
    int menores = 0;
    int sumaneg2 = 0;
    int promedio2 = 0;
    do
    {
        Console.WriteLine("Ingrese un numero");
        numero2 = int.Parse(Console.ReadLine());
        if (numero2 < 99)
        {
            menores++;
            sumaneg2 += numero2;
        }

    } while (numero2 <= 99);

    if (menores > 0)
    {
        promedio2 = sumaneg2 / menores;
    }

    Console.WriteLine("El numero ingresado es: " + numero2);
    Console.WriteLine("Su promedio es: " + promedio2);
    */
}
