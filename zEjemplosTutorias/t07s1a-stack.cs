// Pide al usuario textos, que guardarás en una pila,
// hasta que teclee Intro sin introducir ningún texto.

// En ese momento, extrae todo el contenido de la pila
// y muéstralo (aparecerá en orden inverso).


using System;
using System.Collections;

class EjemploPilas1
{
    static void Main()
    {
        Stack pila = new Stack();
        string texto = Console.ReadLine();
        while(texto != "")
        {
            pila.Push(texto);
            texto = Console.ReadLine();
        }

        int cantidad = pila.Count;
        for (int i = 0; i < cantidad; i++)
        {
            string textoMostrar = (string) pila.Pop();
            Console.WriteLine(textoMostrar);
        }
    }
}
