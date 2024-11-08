/*
Pide al usuario 5 números reales de doble precisión. Después muéstralos 
en orden inverso al que se usó para introducirlos.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        double[] numeros = new double[5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dime el dato número {0}: ", i+1);
            numeros[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        Console.WriteLine("Tus datos (al revés) eran:");
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

/*
Dime el dato número 1: 10
Dime el dato número 2: 20
Dime el dato número 3: 30
Dime el dato número 4: 40
Dime el dato número 5: 50
Tus datos (al revés) eran:
50
40
30
20
10
*/
