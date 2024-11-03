/* Pide al usuario dos números enteros largos y calcula (y muestra) su 
división con decimales.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        long n1, n2;
        
        Console.Write("Dime un número: ");
        n1 = Convert.ToInt64( Console.ReadLine() );
        
        Console.Write("Dime otro número: ");
        n2 = Convert.ToInt64( Console.ReadLine() );
        
        Console.WriteLine("Su división es {0}", 
            n1 / (double) n2 );
        
        /* Alternativa:
        Console.WriteLine("Su división es {0}", 
            n1 / Convert.ToDouble(n2));
        */
    }
}

/*
Dime un número: 123456789012345
Dime otro número: 987654321012
Su división es 124,999998871918
*/

