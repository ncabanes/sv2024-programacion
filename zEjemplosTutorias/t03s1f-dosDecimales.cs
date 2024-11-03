/* Pide al usuario dos números enteros largos y calcula (y muestra) su 
división con dos cifras decimales.
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
        
        double division = n1 / (double) n2;
        
        Console.WriteLine("Su división es {0}", 
            division.ToString("0.00") );
    }
}

/*
Dime un número: 2
Dime otro número: 3
Su división es 0,67
*/

