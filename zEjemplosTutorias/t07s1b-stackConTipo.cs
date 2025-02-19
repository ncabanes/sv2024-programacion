// Crea una versión alternativa del ejercicio anterior,
// usando Generics:

// Pide al usuario textos, que guardarás en una pila
// de "string", hasta que teclee Intro sin introducir
// ningún texto.

// En ese momento, extrae todo el contenido de la pila
// y muéstralo (aparecerá en orden inverso).



using System;
using System.Collections.Generic;

class EjemploPilas2
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();
        string texto = Console.ReadLine();
        while(texto != "")
        {
            pila.Push(texto);
            texto = Console.ReadLine();
        }

        int cantidad = pila.Count;
        for (int i = 0; i < cantidad; i++)
        {
            string textoMostrar = pila.Pop();
            Console.WriteLine(textoMostrar);
        }
    }
}
