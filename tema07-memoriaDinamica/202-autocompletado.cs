/* Ejercicio 202. Autocompletado con el fichero words.txt.
 * 
 * (¿Difícil?) A partir del fichero "words.txt" (que está comprimido en un
 * archivo "words.zip" en GitHub y en Aules), crea un programa que sugiera
 * palabras que comiencen por las letras que vaya tecleando el usuario, como el
 * autocompletado de las búsquedas en Google. Puedes ayudarte de un
 * "SortedSet". */

using System;
using System.Collections.Generic;
using System.IO;

class Autocompletado
{
    static void Main()
    {
        char letra;
        string palabra = "";
        ConsoleKeyInfo tecla;
        string[] lineas = File.ReadAllLines("words.txt");

        SortedSet<string> listaPalabras = new SortedSet<string>(lineas);

        do
        {
            Console.Clear();
            Console.Write("Introduzca letras de la palabra a buscar: ");
            Console.WriteLine(palabra);
            Console.WriteLine();
            
            Mostrar(listaPalabras, palabra);
            tecla = Console.ReadKey();
            
            if (tecla.Key != ConsoleKey.Backspace)
            {
                letra = tecla.KeyChar;
                palabra += letra;
            }
            else if (palabra.Length > 0)
            {
                palabra = palabra.Substring(0, palabra.Length - 1);
            }
        }
        while (tecla.Key != ConsoleKey.Escape);
    }

    static void Mostrar(SortedSet<string> palabras, string palabra)
    {
        int palabrasAMostrar = 10;
        int mostradas = 0;

        foreach (string p in palabras)
        {
            if (palabra.Length > 0 && p.StartsWith(palabra)
                && mostradas < palabrasAMostrar)
            {
                Console.WriteLine(p);
                mostradas++;
            }
        }
        if (mostradas == 0)
            Console.WriteLine("(Sin coincidencias)");
    }
}
