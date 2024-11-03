/* Pide al usuario un número entero corto y muestra su equivalente en 
hexadecimal con 4 cifras.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        short n;
        
        Console.Write("Dime un número: ");
        n = Convert.ToInt16( Console.ReadLine() );
        
        Console.WriteLine("En hexadecimal es {0}", 
            n.ToString("X4"));
    }
}

/*
Dime un número: 110
En hexadecimal es 006E
*/
