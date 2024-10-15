// José (...)

/* Muestra en una misma línea de pantalla tantos asteriscos como indique el 
usuario, y avanza de línea tras escribirlos. Debes emplear "for". */

using System;

class Ejercicio37
{
    static void Main()
    {
        int a;
        
        Console.Write("Introduce cuántos asteriscos quieres mostrar: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        for(int b = 1 ; b <= a ; b++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


