/*Muestra 50 asteriscos en la misma línea, usando "while", y avanza de 
línea tras escribirlos. */ 

//Por Lucía

using System;
                    
class Ejercicio26
{
    static void Main()
    {
        int x;
        x = 1;
                
        while ( x <= 50)
        {
            Console.Write("*");
            x++;
        }
        Console.WriteLine();
    }
}
