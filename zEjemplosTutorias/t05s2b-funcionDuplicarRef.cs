/* Prueba la función "Duplicar", usando parámetros "ref". Comprueba que 
ahora sí se modifica el valor que le pases como parámetro.
 */

using System;

class Ejemplo 
{
    static void Duplicar(ref int n)
    {
        n *= 2;
        //Console.WriteLine(n);
    }
    
    static void Main() 
    {
        int dato = 10;
        Console.WriteLine(dato);
        Duplicar(ref dato);
        Console.WriteLine(dato);
    }
}

/*
10
20
*/
