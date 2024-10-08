// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Ejercicio 2

/* Escribe los números pares del 10 al 20, con un "for" 
 * que declare la variable "al vuelo".
 */

using System;

class ContadorFor2
{
    static void Main() 
    {
        // Caso general
        for (int i = 10; i <= 20; i ++ )
        {
            if (i % 2 == 0)
                Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
        // En este caso, sé que empieza en par
        for (int i = 10; i <= 20; i += 2 )
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
