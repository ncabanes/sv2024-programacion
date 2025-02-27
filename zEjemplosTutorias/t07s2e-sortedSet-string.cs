// Pide palabras al usuario, y guárdalas (sin duplicados)
// en un Conjunto. Cuando pulse Intro para terminar,
// pregunta al usuario cuál quiere buscar y dile si está o no.
// Finalmente, muestra todas las palabras.

using System;
using System.Collections.Generic;

class Ejemplo
{
    static void Main()
    {
        SortedSet<string> conjunto = new SortedSet<string>();
        conjunto.Add("tarde");
        conjunto.Add("noche");

        string palabra;
        do
        {
            Console.WriteLine("Dime una palabra");
            palabra = Console.ReadLine();
            if (palabra != "")
                conjunto.Add(palabra);
        }
        while (palabra != "");

        Console.Write("Qué buscamos? ");
        string buscar = Console.ReadLine();

        if (conjunto.Contains(buscar))
            Console.WriteLine("Está");
        else
            Console.WriteLine("No está");

        foreach (string dato in conjunto)
        {
            Console.Write(dato + " ");
        }
    }
}
