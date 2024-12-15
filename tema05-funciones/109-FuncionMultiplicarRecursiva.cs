/*
109. Crea una función "MultiplicarR", que calcule y devuelva el producto de dos 
números naturales que se indiquen como parámetros, de forma recursiva (por 
ejemplo, puede tomar como caso base que el segundo número sea 0).
*/

using System;

class Ejercicio109
{
    static int MultiplicarR(int num, int multiplicador)
    {
        if (multiplicador == 0)
            return 0;
        else
            return num + MultiplicarR(num, multiplicador - 1);
    }

    static void Main()
    {
        int n1 = 5;
        int n2 = 3;

        Console.WriteLine( MultiplicarR(n1, n2) );
    }
}
