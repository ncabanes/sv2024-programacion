/*
Pide al usuario 5 números reales de doble precisión. 
Después muéstralos en orden inverso de dos formas: 
Usando una constante para el tamaño.
Empleando ".Length"

*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        const int TAMANYO = 5;
        double[] numeros = new double[TAMANYO];
        
        for (int i = 0; i < TAMANYO; i++)
        {
            Console.Write("Dime el dato número {0}: ", i+1);
            numeros[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        Console.WriteLine("Tus datos (al revés) eran:");
        for (int i = TAMANYO-1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
        
        Console.WriteLine("Tus datos (al revés, versión 2) eran:");
        for (int i = numeros.Length-1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

/*
Dime el dato número 1: 10
Dime el dato número 2: 20
Dime el dato número 3: 30
Tus datos (al revés) eran:
30
20
10
Tus datos (al revés, versión 2) eran:
30
20
10
*/
