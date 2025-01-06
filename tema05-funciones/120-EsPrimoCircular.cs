/*
120. Crea una función EsPrimoCircular, que devuelva true si el número entero 
largo pasado como parámetro es un primo circular 
(http://en.wikipedia.org/wiki/Circular_prime) (puedes ayudarte de una función 
auxiliar EsPrimo, si te parece razonable): 

if (EsPrimoCircular(113))
    Console.Write("113 es primo circular");
if (! EsPrimoCircular(23))
    Console.Write("23 no es primo circular");
*/

using System;

class Ejercicio120
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
    
    
    static bool EsPrimoCircular(long numero)
    {
        int contadorPrimos = 0;
        
        string numeroComoCadena = Convert.ToString(numero);
        for (int i = 0; i < numeroComoCadena.Length; i++)
        {
            // Colocamos la última cifra al principio
            numeroComoCadena = numeroComoCadena[numeroComoCadena.Length - 1] +
                numeroComoCadena.Substring(0, numeroComoCadena.Length - 1);
            // Y vemos si el resultado es primo
            if (EsPrimo(Convert.ToInt64(numeroComoCadena)))
            {
                contadorPrimos++;
            }
        }
        return contadorPrimos == numeroComoCadena.Length;
    }
    
    
    static void Main()
    {
        Console.Write("Introduce un número: ");
        long numero = Convert.ToInt64(Console.ReadLine());

        if(EsPrimoCircular(numero))
        {
            Console.Write(numero + " es primo circular");
        }        
        else
        {
            Console.Write(numero + " no es primo circular");
        }
    }
}
