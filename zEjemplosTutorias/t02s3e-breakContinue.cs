// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Ejercicio 5

/* Escribe los números del 10 al 20 excepto el 12, 
 * de 1 en 1, de 2 formas distintas (con "continue" y sin él).
 *
 * A continuación, interrumpe antes de mostrar el 15 
 * (con "break" y sin él). 
 */

using System;

class BreakContinue
{
    static void Main() 
    {
        for (int i = 10; i <= 20; i++)
        {
            if (i == 12)
            {
                continue;
            }
            Console.Write(i);
        }
        
        for (int i = 10; i <= 20; i++)
        {
            if (i != 12)
            {
                Console.Write(i);
            }
        }
        
        for (int i = 10; i <= 20; i++)
        {
            if (i == 15)
            {
                break;
            }
            Console.Write(i);
        }
        
        for (int i = 10; i <= 14; i++)
        {
            Console.Write(i);
        }
    }
}
