// Crea una versión alternativa del ejercicio 2, usando
// una cola (los datos aparecerán en el mismo orden en
// que se introdujeron).

using System;
using System.Collections.Generic;

class EjemploCola
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        string texto = Console.ReadLine();
        while(texto != "")
        {
            cola.Enqueue(texto);
            texto = Console.ReadLine();
        }

        int cantidad = cola.Count;
        for (int i = 0; i < cantidad; i++)
        {
            string textoMostrar = cola.Dequeue();
            Console.WriteLine(textoMostrar);
        }
    }
}
