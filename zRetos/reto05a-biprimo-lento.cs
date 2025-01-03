/*
Reto 05: Biprimos

Problema a resolver

En matemáticas, un número semiprimo, también llamado biprimo, es un número 
natural que es producto de dos números primos no necesariamente distintos. Los 
semiprimos menores que 100 son 4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 
38, 39, 46, 49, 51, 55, 57, 58, 62, 65, 69, 74, 77, 82, 85, 86, 87, 91, 93, 94, 
y 95. Tu programa recibirá una serie de números enteros largos, cada uno en una 
línea distintas, hasta terminar con 0, y, para cada uno de ellos, responderá 
"BIPRIMO", en caso de que sea biprimo, o, en caso contrario, responderá 
"PRIMO", si es primo, o "COMPUESTO", si no es bripimo y tampoco primo. Es 
altamente recomendable que crees funciones auxiliares, al menos una que te 
permita saber si el número es primo o no, y lo ideal sería también crear otra 
función "EsBiprimo" que se apoye en la anterior.

Datos de entrada

Cada línea de entrada contendrá un entero largo. La última línea tendrá un 0, 
que no debe procesarse.

Ejemplo de entrada

9
5
8
21
23
24
12345678901234567
123456789012345671
1234567890123456789
0

Salida que se debería obtener con esa entrada:

BIPRIMO
PRIMO
COMPUESTO
BIPRIMO
PRIMO
COMPUESTO
BIPRIMO
PRIMO
COMPUESTO
*/

// Version 1, lenta

using System;

class Biprimos
{
    static void Main()
    {
        long numero = Convert.ToInt64(Console.ReadLine());
        while (numero != 0)
        {
            if (EsBiprimo(numero))
            {
                Console.WriteLine("BIPRIMO");
            }
            else if (EsPrimo(numero))
            {
                Console.WriteLine("PRIMO");
            }
            else
            {
                Console.WriteLine("COMPUESTO");
            }
            
            numero = Convert.ToInt64(Console.ReadLine());
        }
    }

    static bool EsPrimo(long numero)
    {
        // Primera aproximación, la que ya conocemos, lenta
        int divisores = 0;
        for (long i = 1; i <= numero; i++)
        {
            if (numero % i == 0) divisores++;
        }
        return divisores == 2;
    }

    static bool EsBiprimo(long numero)
    {
        // Primera aproximación, lenta
        bool biprimo = false;
        for (long i = 2; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                if (EsPrimo(i) && EsPrimo(numero / i)) biprimo = true;
            }
        }
        return biprimo;
    }
}
