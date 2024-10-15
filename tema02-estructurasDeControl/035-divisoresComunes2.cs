/******************************************************************************
Liberto (...)

35. Crea una variante mejorada del ejercicio anterior: un programa que le pida al
usuario dos números y muestre sus divisores comunes (excepto el 1), o el texto
"Ninguno", en caso de no encontrar ningún divisor común (distinto del 1).

*******************************************************************************/

using System;

class Ejercicio35 
{
    static void Main() 
    {
    
        int n1, n2;
        int posibleDivisor;
        int maximo;
        int encontrados = 0;

        Console.WriteLine("Introduzca un número");
        n1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca otro número");
        n2=Convert.ToInt32(Console.ReadLine());

        maximo = (n1 < n2) ? n1:n2;

        Console.Write("Sus divisores comunes son: ");

        for (posibleDivisor = 2; posibleDivisor <= maximo; posibleDivisor++)
        {
            if (n1 % posibleDivisor == 0 
                && n2 % posibleDivisor == 0)
            {
                encontrados++;
                Console.Write("{0} ", posibleDivisor);
            }
        }

        if (encontrados == 0)
        {
            Console.WriteLine("Ninguno");
        }
    }
}
