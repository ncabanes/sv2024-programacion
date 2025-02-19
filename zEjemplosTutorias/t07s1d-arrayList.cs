// Crea una versión alternativa del ejercicio 3, usando
// una lista: el usuario introducirá textos hasta que
// pulse Intro. Después deberás mostrarlos dos veces:
// primero en orden de introducción y luego en orden inverso.


using System;
using System.Collections;

class EjemploLista
{
    static void Main()
    {
        ArrayList lista = new ArrayList();
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
            string textoMostrar = (string) lista[i];
            Console.WriteLine(textoMostrar);
        }
    }
}
