
// Crea un diccionario castellano-valenciano usando una SortedList. Añade dos
// palabras prefijadas y pide otras dos (con su traducción). Luego muestra
// una de las prefijadas, y después todas ellas usando un esqueleto como éste:

// for (int i = 0; i < miDiccio.Count; i++)
//    Console.WriteLine("{0} = {1}",
//       miDiccio.GetKey(i), miDiccio[miDiccio.GetKey(i)]);

using System;
using System.Collections;

class Ejemplo
{
    static void Main()
    {
        SortedList d = new SortedList();
        d.Add("tarde", "vesprada");
        d["noche"] = "nit";

        Console.WriteLine("Dime una palabra");
        string palabra = Console.ReadLine();
        Console.WriteLine("Dime su traducción");
        string trad = Console.ReadLine();
        d.Add(palabra, trad);

        Console.WriteLine("Dime una palabra");
        palabra = Console.ReadLine();
        Console.WriteLine("Dime su traducción");
        trad = Console.ReadLine();
        d[palabra] = trad;

        if (d.Contains("noche"))
            Console.WriteLine( d["noche"] );

        for (int i = 0; i < d.Count; i++)
        {
            string clave = (string) d.GetKey(i);
            string valor = (string) d[ clave ];
            Console.WriteLine("{0} = {1}",
               clave,valor);
        }
    }
}
