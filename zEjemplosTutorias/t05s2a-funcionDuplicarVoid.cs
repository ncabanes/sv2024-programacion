/* Prueba esa función "Duplicar". Comprueba que no se modifica el valor 
que le pases como parámetro. */

using System;

class Ejemplo 
{
    static void Duplicar(int n)
    {
        n *= 2;
        Console.WriteLine(n);
    }
    
    static void Main() 
    {
        int dato = 10;
        Console.WriteLine(dato);
        Duplicar(dato);
        Console.WriteLine(dato);
    }
}

/*
10
20
10
*/
