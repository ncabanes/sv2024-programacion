// Recorre el Dictionary del ejercicio 4 usando
// "foreach" (y obteniendo pares, en vez de mirar
// la propiedad "Keys").

using System;
using System.Collections.Generic;

class Ejemplo
{
    static void Main()
    {
        Dictionary<string, string> d = new Dictionary<string, string>();
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

        if (d.ContainsKey("noche"))
            Console.WriteLine(d["noche"]);

        foreach (KeyValuePair<string, string> dato in d)
        {
            Console.WriteLine("{0} = {1}",
               dato.Key, dato.Value);
        }
    }
}
