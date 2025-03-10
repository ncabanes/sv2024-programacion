/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 199. Achivos words.txt / words2.txt con HashSet.
 * 
 * En realidad, no necesitamos una clave y un valor para las palabras de los
 * 3 ejercicios anteriores. Haz una nueva versión que emplee dos conjuntos
 * (HashSet).. */

// Creando lista ordenada con palabras ...
// Momento actual: 07 / 03 / 2025 20:58:50
// Tiempo transcurrido: 00:00:00.0202419
// Coincidencias en archivos: 210651

using System;
using System.Collections.Generic;
using System.IO;

class ArchivosWords {

    static void Main() {

        HashSet<string> palabras1 = new HashSet<string>();
        HashSet<string> palabras2 = new HashSet<string>();

        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");

        Console.WriteLine("Creando HashSet con palabras ...");
        foreach (string palabra in words) {
            if (palabras1.Contains(palabra) == false) {
                palabras1.Add(palabra);
            }
        }

        foreach (string palabra in words2) {
            if (palabras2.Contains(palabra) == false) {
                palabras2.Add(palabra);
            }
        }

        DateTime comienzo = DateTime.Now;
        Console.Write("Momento actual: " + comienzo);
        Console.WriteLine();

        int contador = 0;
        foreach (string palabra in palabras2) {
            if (palabras1.Contains(palabra)) {
                contador++;
            }
        }

        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Coincidencias en archivos: " + contador);

    }

}
