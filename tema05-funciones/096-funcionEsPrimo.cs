/* 96. Crea una función booleana llamada "EsPrimo", que devolverá true si el 
parámetro (un entero largo) es un número primo, o false en caso contrario. 
Recuerda que un número primo es el que tiene exactamente 2 divisores (el 1 y el 
propio número). Empléala en un programa que muestre los números primos entre el 
1 y el 100. */

using System;

class Ejercicio96
{
    static bool EsPrimo(long numero)
    {
        int divisores = 0;
        bool esPrimo = false;

        for (long i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            esPrimo = true;
        }

        return esPrimo;
    }
    
    static void Main()
    {
        Console.Write("Números primos del 1 al 100: ");
        for (int i = 0; i < 100; i++)
        {
            if (EsPrimo(i))
                Console.Write(i + " ");
        }
    }
}
