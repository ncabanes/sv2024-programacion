/*
Pide al usuario dos números enteros. Calcula (y muestra) el menor de 
ellos. Hazlo primero con "if" y luego con el "operador ternario" u 
"operador condicional".
*/

using System;

class WhileAcercamiento 
{
    static void Main() 
    {
        Console.Write("Qué quieres dividir? ");
        int dividendo = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Entre qué quieres dividirlo? ");
        int divisor = Convert.ToInt32( Console.ReadLine() );

        while (divisor == 0)
        {
            Console.WriteLine ( "No debe ser cero" );
            Console.Write("Entre qué quieres dividirlo? ");
            divisor = Convert.ToInt32( Console.ReadLine() );
        }
        Console.Write("La división es ");
        Console.WriteLine ( dividendo / divisor );
    }
}

