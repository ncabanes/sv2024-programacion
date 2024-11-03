/* Pide al usuario un número entre el 0 y el 100, con un máximo de 2 
cifras decimales (escoge el tipo de datos más adecuado). Calcula y 
muestra su mitad. */

using System;

class Ejemplo 
{
    static void Main() 
    {
        float n;
        
        Console.WriteLine("Dime un número");
        n = Convert.ToSingle( Console.ReadLine() );
        
        float mitad = n / 2;
        Console.WriteLine("Su mitad es {0}", mitad);
    }
}

/*
Dime un número
7
Su mitad es 3,5
*/
