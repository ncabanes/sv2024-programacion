// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Ejercicio 1

/* Escribe los números del 0 al 10 y luego los números del 10 al 0. 
Debes emplear dos bucles "for".
 */

using System;

class ContadorFor
{
    static void Main() 
    {
        int i;
        int x;
               
        for ( i = 0 ; i <= 10 ; i++ )
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine(); // Línea en blanco
        
        for ( i = 10; i >= 0 ; i-- )
        {
            Console.WriteLine(i);
        }
        
        // Bonus: texto subrayado (varios guiones en la misma línea)
        
        Console.WriteLine("Hola que tal");
        
        for (x = 1; x <= 12; x++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}
