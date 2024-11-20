/*
Pide al usuario 5 números reales de doble precisión. 
Ordénalos utilizando selección directa.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        double[] datos = { 100, 150, 50, 300, 200 };
        
        for (int i = 0; i < datos.Length-1; i++)  
        {
            int posicMenor = i;
            for (int j = i+1; j < datos.Length; j++)
                if (datos[j] < datos[posicMenor])
                    posicMenor = j;
            if (posicMenor != i)  
            {
                double aux = datos[i];
                datos[i] = datos[posicMenor];
                datos[posicMenor] = aux;
            }
            
            for (int pos = 0; pos < datos.Length; pos++)
            {
                Console.Write(datos[pos] + " ");
            }
            Console.WriteLine();
        }
    }
}

/*
100, 150, 50, 300, 200
50 150 100 300 200
50 100 150 300 200
50 100 150 300 200
50 100 150 200 300
*/
