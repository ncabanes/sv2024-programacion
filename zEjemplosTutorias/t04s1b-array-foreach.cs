/*
Pide al usuario 5 números reales de doble precisión. 
Después, usando "foreach", calcula su media y 
muestra los que están por encima de la media.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        double[] numeros = new double[5];
        double suma, media;
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dime el dato número {0}: ", i+1);
            numeros[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        suma = 0;
        foreach(double n in numeros)
        {
            suma += n;
        }
        media = suma / 5;
        
        Console.WriteLine("Por encima de la media {0}:", media);
        
        foreach(double dato in numeros)
        {
            if (dato > media)
                Console.WriteLine(dato);
        }
    }
}

/*
Dime el dato número 1: 50
Dime el dato número 2: 40
Dime el dato número 3: 30
Dime el dato número 4: 20
Dime el dato número 5: 10
Por encima de la media 30:
50
40
*/
