// Crea una versión alternativa del ejercicio 4, usando
// una lista con tipo (string): el usuario introducirá
// textos hasta que pulse Intro. Después deberás mostrarlos
// dos veces: primero en orden de introducción y luego en
// orden inverso.

using System;
using System.Collections.Generic;

class EjemploLista2
{
    static void Main()
    {
        List<string> lista = new List<string>();
        string texto = Console.ReadLine();
        while(texto != "")
        {
            lista.Add(texto);
            texto = Console.ReadLine();
        }

        // Orden directo
        foreach(string t in lista)
        {
            Console.WriteLine(t);
        }

        Console.WriteLine();

        // Orden inverso
        int cantidad = lista.Count;
        for (int i = cantidad-1; i >= 0; i--)
        {
            string textoMostrar = lista[i];
            Console.WriteLine(textoMostrar);
        }
    }
}
