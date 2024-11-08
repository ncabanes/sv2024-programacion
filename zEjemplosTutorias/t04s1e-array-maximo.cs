/*
Pide al usuario 5 números reales de doble precisión. 
Después muestra su máximo.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        double[] numeros = new double[5];
        double maximo;
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dime el dato número {0}: ", i+1);
            numeros[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        maximo = numeros[0];
        foreach(double n in numeros)
        {
            if (n > maximo)
                maximo = n;
        }
        Console.WriteLine("El máximo es : " + maximo);
    }
}

/*
Dime el dato número 1: 10
Dime el dato número 2: 50
Dime el dato número 3: 40
Dime el dato número 4: 30
Dime el dato número 5: 20
El máximo es : 50
*/
