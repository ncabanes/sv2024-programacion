/*
108. Crea una función "Multiplicar", que calcule y devuelva el producto de dos 
números naturales (enteros no negativo) que se indiquen como parámetros, a base 
de sumas repetitivas, de forma "iterativa" (no recursiva), usando la orden 
"for" (por ejemplo, "Multiplicar(3,5)" calculará 3+3+3+3+3 o bien 5+5+5, según 
decidas plantearlos).
*/

using System;

class Ejercicio108
{
    static int Multiplicar(int num, int multiplicador)
    {
        int producto = 0;
        for (int n = 0; n < multiplicador; n++)
        {
            producto += num;
        }
        
        return producto;
    }

    static void Main()
    {
        int n1 = 5;
        int n2 = 3;

        Console.WriteLine( Multiplicar(n1, n2) );
    }
}
