// Pide al usuario varios números enteros,
// guárdalos en una lista y luego muestra
// los positivos ordenados.

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        string linea;
        do
        {
            linea = Console.ReadLine();
            if (linea != "")
            {
                numeros.Add(Convert.ToInt32(linea));
            }
        }
        while (linea != "");

        // SELECT numero FROM numeros
        // WHERE numero > 0
        // ORDER BY numero;

        var resultados = 
            from n in numeros
            where n > 0
            orderby n
            select n;

        Console.WriteLine("Formato largo");
        foreach (var r in resultados)
        {
            Console.Write(r + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Formato compacto");
        var resultados2 = numeros
            .Where(n => n > 0)
            .OrderBy(n => n);

        foreach (var r in resultados2)
        {
            Console.Write(r + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Con .ForEach");
        numeros.Where(n => n > 0)
            .OrderBy(n => n)
            .ToList()
            .ForEach(n => Console.Write(n + " "));
        Console.WriteLine();
    }
}
