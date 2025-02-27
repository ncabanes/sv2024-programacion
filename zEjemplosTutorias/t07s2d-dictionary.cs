// Crea una variante del ejercicio anterior usando
// Dictionary<string, string>


using System;
using System.Collections.Generic;

class Ejemplo
{
    static void Main()
    {
        Dictionary<string,string> d = new Dictionary<string, string>();
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

        foreach (string clave in d.Keys)
        {
            string valor = (string) d[clave];
            Console.WriteLine("{0} = {1}",
               clave, valor);
        }
    }
}
