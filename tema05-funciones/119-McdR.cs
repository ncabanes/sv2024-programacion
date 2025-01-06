/* 

119. El máximo divisor común (MCD) de dos números A y B se puede calcular de 
forma recursiva utilizando el algoritmo de Euclides: si B es 0, la respuesta es 
A; De lo contrario, debemos probar el MCD de B y A % B. 

Crea dos funciones que devuelvan el MCD de dos números enteros largos: una debe 
ser iterativa (NO recursivo, sino usando "for" o "while"), y debe llamarse 
"Mcd". La segunda función debe hacerlo de forma recursiva, utilizando el 
algoritmo de Euclides y debe llamarse "McdR". Un ejemplo de uso podría ser

Console.Write ( McdR( 30, 18) ); // Mostraría 6

*/

using System;

class Ejercicio119
{
    static int McdR(int a, int b)
    {
        if (b == 0)
            return a;
        return McdR(b, a % b);
    }

    static int Mcd(int a, int b)
    {
        // MCD usando la versión iterativa del algoritmo de Euclides
        while (b != 0)
        {
            int aux = b;
            b = a % b;
            a = aux;
        }
        return a;
    }


    static void Main()
    {
        Console.WriteLine(Mcd(30, 18));
        Console.WriteLine(McdR(30, 18));
        
        Console.WriteLine(Mcd(18, 30));
        Console.WriteLine(McdR(18, 30));
    }
}
