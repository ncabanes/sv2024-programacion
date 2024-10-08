// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Variante del Ejercicio 3


/* Una tabla de multiplicar
 */

using System;

class UnaTablaMult
{
    static void Main() 
    {
        Console.WriteLine("Qué tabla quieres?");
        int n = Convert.ToInt32( Console.ReadLine() );

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", 
                n, i, n*i);
        }
    }
}

/*
Qué tabla quieres?
6
6 x 0 = 0
6 x 1 = 6
6 x 2 = 12
6 x 3 = 18
6 x 4 = 24
6 x 5 = 30
6 x 6 = 36
6 x 7 = 42
6 x 8 = 48
6 x 9 = 54
6 x 10 = 60
*/
