/* Escribe los números del 0 al 10 y luego los números del 10 al 0. 
Debes emplear dos bucles "while". */

using System;

class ContadorWhile 
{
    static void Main() 
    {
        int i;
        
        i = 0;
        while ( i <= 10 )
        {
            Console.WriteLine(i);
            i++;
        }
        
        Console.WriteLine(); // Línea en blanco
        
        i = 10;
        while ( i >= 0 )
        {
            Console.WriteLine(i);
            i--;
        }
        
        // Bonus: texto subrayado (varios guiones en la misma línea)
        
        Console.WriteLine("Hola que tal");
        
        int x = 1;
        while (x <= 12)
        {
            Console.Write("-");
            x++;
        }
        Console.WriteLine();
    }
}
