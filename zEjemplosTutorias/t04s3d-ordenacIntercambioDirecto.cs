/*
Pide al usuario 5 números reales de doble precisión. 
Ordénalos utilizando intercambio directo.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        double[] datos = { 100, 150, 50, 300, 200 };
        
        for (int i = 0; i < datos.Length-1; i++)
        {
            for (int j = i+1; j < datos.Length; j++)
            {
                if (datos[i] > datos[j])
                {
                    double temporal = datos[i];
                    datos[i] = datos[j];
                    datos[j] = temporal;
                }
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
50 150 100 300 200
50 100 150 300 200
50 100 150 300 200
50 100 150 200 300
*/
