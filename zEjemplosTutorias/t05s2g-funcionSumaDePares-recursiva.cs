/* Crea una función recursiva "SumaDePares", que reciba como parámetro 
un número entero y devuelva la suma de los números positivos desde ese 
número hasta 0 (decreciendo) que sean pares. */

using System;

class Ejemplo 
{
    static int SumaDePares(int n)
    {
        if (n <= 1)
            return 0;
        
        // 1000 -> 1000 + pares(998)
        if (n % 2 == 0)
            return n + SumaDePares(n-2);
        // 999 -> pares(998)
        else
            return SumaDePares(n-1);
    }
    
    static void Main() 
    {
        Console.WriteLine( SumaDePares(6) );
    }
}

/*
12
*/
