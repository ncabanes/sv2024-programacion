// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Ejercicio 4

/* Aplica el ejemplo anterior: dibuja un rectángulo 
 * formado por 4 filas, cada una con 8 letras M.
 */

using System;

class Rectangulo
{
    static void Main() 
    {
        // Lo que me pedían: rectángulo relleno
        for (int fila = 1; fila <= 4; fila++)
        {
            for(int columna = 1; columna <= 8; columna++)
            {
                Console.Write("M");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        
        // Bonus 1: triángulo
        for (int fila = 1; fila <= 4; fila++)
        {
            for(int columna = 1; columna <= fila; columna++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        
        // Bonus 2: rectángulo hueco
        for (int fila = 1; fila <= 5; fila++)
        {
            for(int columna = 1; columna <= 12; columna++)
            {
                if ((fila == 1) || (fila == 5)
                        || (columna == 1) || (columna == 12))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }   
        
        Console.WriteLine();     
        
        // Bonus 3: rectángulo hueco, forma 2
        
        // Primera fila
        for(int columna = 1; columna <= 12; columna++)
            Console.Write("*");
        Console.WriteLine();
            
        // Zona central
        for (int fila = 2; fila <= 4; fila++)
        {
            Console.Write("*");
            for(int columna = 2; columna <= 11; columna++)
            {
               Console.Write(" ");
            }
            Console.WriteLine("*");
        }  
        
        // Ultima fila
        for(int columna = 1; columna <= 12; columna++)
            Console.Write("*");
        Console.WriteLine();
    }
}
