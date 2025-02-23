/* 192. Como veremos con más detalle en el tema 8, una forma rápida de leer 
todo el contenido de un fichero de texto es emplear "string[ ] lineas = 
File.ReadAllLines("nombreDeFichero.ext");" (necesitarás añadir también "using 
System.IO;"). Además, puedes crear una lista a partir de ese array de strings 
con "List<string> lista = new List<string>(lineas);". Haz un programa que 
pregunte el nombre de un fichero de texto, lo lea y muestre su contenido al 
revés (de la última línea a la primera).

(Como mejora opcional, puedes hacer que se guarde el resultado en otro fichero 
cuando termine la ejecución, con "File.WriteAllLines("nombre2.ext", 
miLista.ToArray());"). */

using System;
using System.IO;
using System.Collections.Generic;

class InvertirFichero
{
    static void Main(string[] args)
    {
        List<string> lineas;
        Console.Write("Escribe el nombre del fichero: ");

        lineas = new List<string>(File.ReadAllLines(Console.ReadLine()));
        for(int i = lineas.Count - 1; i >= 0; i--) 
        {
            Console.WriteLine(lineas[i]);
        }
    }
}
