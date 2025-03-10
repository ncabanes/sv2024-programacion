/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 196. Achivos words.txt / words2.txt.
 * 
 * Como ya descubriste en el ejercicio 192, y como verás con más detalle en el
 * tema 8, una forma rápida de leer todo el contenido de un fichero de texto es
 * emplear
 * 
 * "string[] lineas = File.ReadAllLines("nombreDeFichero.ext");"
 * 
 * (necesitarás añadir también "using System.IO;"). Crea un programa que lea
 * el contenido del fichero words.txt (cerca de 355.000 palabras, que tienes
 * compartido en Aules comprimido, como fichero words.zip) y el contenido del
 * fichero words2.txt (cerca de 235.000 palabras, que tienes compartido en
 * Aules comprimido, como fichero words2.zip). Deberá mostrar en pantalla la
 * cantidad de palabras que aparecen a la vez en ambos ficheros. Esta primera
 * versión trabajará directamente con los datos de los arrays que obtienes al
 * leer ambos ficheros. Si tienes curiosidad por medir el tiempo que tarda,
 * puedes emplear esta estructura:
 * 
 * DateTime comienzo = DateTime.Now;
 * // Aquí va lo que se quiere medir
 * Console.WriteLine("Tiempo transcurrido: "+  (DateTime.Now-comienzo)); */

// Leyendo archivos ...
// Momento actual: 07 / 03 / 2025 21:01:32
// Tiempo transcurrido: 00:04:59.5613941 -----> zzzZZZzzzZZZZZZZzzzzzzzz
// Coincidencias en archivos: 210651

using System;
using System.IO;

class ArchivosWords {

    static void Main() {

        Console.WriteLine("Leyendo archivos ... ");
        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");

        DateTime comienzo = DateTime.Now;
        Console.Write("Momento actual: " + comienzo);
        Console.WriteLine();

        int contador = 0;
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words2.Length; j++) {
                if (words[i] == words2[j]) {
                    contador++;
                }
            }
        }

        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Coincidencias en archivos: "+ contador);
    }
}
