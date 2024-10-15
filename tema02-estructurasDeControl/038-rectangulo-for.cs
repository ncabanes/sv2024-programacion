// Isabel (...)

/*
38. Haz un programa que pida al usuario una altura y una anchura 
y que muestre, empleando la orden "for", 
un rectángulo formado por "almohadillas" (el símbolo "hash")
con esa altura y anchura, como en este ejemplo:

Ancho? 3
Alto? 5

###
###
###
###
###
*/

using System;

class Ejercicio38
{
    static void Main()
    {
        int alto, ancho;
        
        Console.Write("Ancho? ");
        ancho = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Alto? ");
        alto = Convert.ToInt32(Console.ReadLine());
        
        for (int fila = 1; fila <= alto; fila++)
        {
            for (int columna = 1; columna <= ancho; columna++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
