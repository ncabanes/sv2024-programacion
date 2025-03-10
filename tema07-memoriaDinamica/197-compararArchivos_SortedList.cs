/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 197. Achivos words.txt / words2.txt con SortedList.
 * 
 * Crea una segunda versión del ejercicio anterior (words.txt y words2.txt),
 * que vuelque el contenido de los ficheros a dos SortedList (puedes usar cada
 * palabra como clave del diccionario y también como valor) antes de contar la
 * cantidad de palabras coincidentes. Debería resultar mucho más rápida que la
 * versión original. */

// Creando lista ordenada con palabras ...
// Momento actual: 07 / 03 / 2025 21:07:50
// Tiempo transcurrido: 00:00:00.4976994
// Coincidencias en archivos: 210651

using System;
using System.Collections.Generic;
using System.IO;

class ArchivosWords {

    static void Main() {

        SortedList<string, string> palabras1 = new SortedList<string, string>();
        SortedList<string, string> palabras2 = new SortedList<string, string>();

        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");

        Console.WriteLine("Creando lista ordenada con palabras ...");
        foreach (string palabra in words) {
            if (palabras1.ContainsKey(palabra) == false) {
                palabras1.Add(palabra, palabra);
            }
        }

        foreach (string palabra in words2) {
            if (palabras2.ContainsKey(palabra) == false) {
                palabras2.Add(palabra, palabra);
            }
        }

        DateTime comienzo = DateTime.Now;
        Console.Write("Momento actual: " + comienzo);
        Console.WriteLine();

        int contador = 0;
        foreach (string palabra in palabras2.Keys) {
            if (palabras1.ContainsKey(palabra)) {
                contador++;
            }
        }

        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Coincidencias en archivos: " + contador);

    }

}
