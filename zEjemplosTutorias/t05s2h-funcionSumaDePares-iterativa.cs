/* Crea una función iterativa "SumaDePares2", que reciba como parámetro 
un número entero y devuelva la suma de los números desde ese número 
hasta 0 (decreciendo) que sean pares.
 */

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
    
    static int SumaDePares2(int n)
    {
        int suma = 0;
        for (int i = 0; i <= n; i+=2)
            suma += i;
        return suma;
    }
    
    
    
    static void Main() 
    {
        Console.WriteLine( SumaDePares(6) );
        Console.WriteLine( SumaDePares2(6) );
    }
}

/*
12
*/
