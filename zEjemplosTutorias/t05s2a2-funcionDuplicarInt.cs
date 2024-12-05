/* (Devolver valor) */

using System;

class Ejemplo 
{
    static int Duplicar(int n)
    {
        return n * 2;
    }
    
    static void Main() 
    {
        int dato = 10;
        Console.WriteLine(dato);
        dato = Duplicar(dato);
        Console.WriteLine(dato);
    }
}

/*
10
20
*/
