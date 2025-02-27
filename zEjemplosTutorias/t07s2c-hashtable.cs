// Crea una nueva versión del diccionario valenciano-castellano
// usando una HashTable. En esta ocasión, para mostrar los datos,
// recorre el array de claves, así:

// using System;
// 
// foreach (string palabra in miDiccio.Keys)
//     Console.WriteLine(palabra + " - " + miDiccio[palabra]);

using System;
using System.Collections;

class Ejemplo
{
    static void Main()
    {
        Hashtable d = new Hashtable();
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
            Console.WriteLine(d["noche"]);

        foreach (string clave in d.Keys)
        {
            string valor = (string) d[clave];
            Console.WriteLine("{0} = {1}",
               clave, valor);
        }
    }
}
