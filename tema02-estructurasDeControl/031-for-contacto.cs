/*31. Muestra los números pares del 10 al 0, ambos inclusive, descendiendo, 
separados por un espacio, sin avanzar de línea, usando "for". Hazlo dos veces 
como parte de un mismo programa: primero disminuyendo de 2 en 2 y luego 
repítelo disminuyendo de 1 en 1 pero comprobando si el número es par antes de 
escribirlo.*/

// Silvia (...)

using System;

class ForDescendente
{
    static void Main()
    {
        for (int n = 10; n >= 0; n-=2)
        {
            Console.Write($"{n} ");
        }
        
        Console.WriteLine();
        
        for (int n = 10; n >= 0; n--)
        {
            if (n % 2 == 0)
            {
                Console.Write($"{n} ");
            }
            
        }
    }
}

