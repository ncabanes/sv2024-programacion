/*
Pide al usuario 5 números reales de doble precisión. 
Ordénalos utilizando inserción directa.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        double[] datos = { 100, 150, 50, 300, 200 };
        
        for (int i=1; i<datos.Length; i++)  
        {
            int j = i - 1;
            while (j >= 0 && datos[j]>datos[j+1])  
            {
                double aux = datos[j];
                datos[j] = datos[j + 1];
                datos[j + 1] = aux;
                j--;
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
100 150 50 300 200
50 100 150 300 200
50 100 150 300 200
50 100 150 200 300
*/
