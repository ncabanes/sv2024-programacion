// Crea una pila de frases introducidas por el usuario.
// Primero recórrela con un "Enumerator", luego con un
// "foreach" y finalmente extrayendo todos los datos
// con "Pop".

using System;
using System.Collections.Generic;

class EjemploPilas2
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();
        string texto = Console.ReadLine();
        while (texto != "")
        {
            pila.Push(texto);
            texto = Console.ReadLine();
        }

        Console.WriteLine("--------- Enumerador ----");

        IEnumerator<string> enumerador = pila.GetEnumerator();
        while (enumerador.MoveNext())
        {
            Console.WriteLine(enumerador.Current);
        }

        Console.WriteLine("--------- foreach -------");

        foreach (string s in pila)
        { 
            Console.WriteLine(s); 
        }

        Console.WriteLine("--------- Pop -----------");

        int cantidad = pila.Count;
        for (int i = 0; i < cantidad; i++)
        {
            string textoMostrar = pila.Pop();
            Console.WriteLine(textoMostrar);
        }
    }
}
