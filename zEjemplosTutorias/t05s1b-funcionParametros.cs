/* Crea una función "EscribirVariasVeces", reciba como parámetros un 
número y un texto, y escriba varias veces en la misma línea ese texto 
(tantas veces como indique el número).
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        Console.Write("Hola ");
        EscribirVariasVeces(5, " -=- ");
        Console.WriteLine("Adios");
        EscribirVariasVeces(3, "Nos vemos pronto! ");
    }
    
    static void EscribirVariasVeces(int veces, string texto) 
    {
        for (int i = 0; i < veces; i++)
        {
            Console.Write(texto);
        }
    }
}

/*
Hola  -=-  -=-  -=-  -=-  -=- Adios
Nos vemos pronto! Nos vemos pronto! Nos vemos pronto!
*/
