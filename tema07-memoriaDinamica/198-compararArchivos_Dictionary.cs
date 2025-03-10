/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 198. Achivos words.txt / words2.txt con Dictionary.
 * 
 * Crea una tercera versión del ejercicio de words.txt y words2.txt, que
 * vuelque el contenido de los ficheros a dos tablas hash o bien a dos
 * Dictionary<string,lo_que_tu_quieras> antes de contar la cantidad de palabras
 * coincidentes. Será aún más rápida que la versión anterior. */

// Creando diccionario con palabras ...
// Momento actual: 07 / 03 / 2025 21:00:24
// Tiempo transcurrido: 00:00:00.0124476
// Coincidencias en archivos: 210651

using System;
using System.Collections.Generic;
using System.IO;

class ArchivosWords {

    static void Main() {

        Dictionary<string, string> palabras1 = new Dictionary<string, string>();
        Dictionary<string, string> palabras2 = new Dictionary<string, string>();

        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");

        Console.WriteLine("Creando diccionario con palabras ...");
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
