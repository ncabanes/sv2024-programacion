/* Pide al usuario dos números enteros. Muestra su división. Si el 
segundo es cero, se lo tendrás que volver a pedir tantas veces como sea 
necesario. Utiliza "do-while".*/

using System;

class DoWhile 
{
    static void Main() 
    {
        int dividendo, divisor;
        
        Console.Write("Qué quieres dividir? ");
        dividendo = Convert.ToInt32( Console.ReadLine() );
        
        do
        {
            Console.Write("Entre qué quieres dividirlo? ");
            divisor = Convert.ToInt32( Console.ReadLine() );
            if (divisor == 0)
            {
                Console.WriteLine ("No debe ser cero");
            }
        } 
        while (divisor == 0);
        
        Console.Write("La división es ");
        Console.WriteLine ( dividendo / divisor );
    }
}

