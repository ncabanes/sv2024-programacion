/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 225. Romper contraseña diccionario.
 * 
 * Intenta romper la contraseña de un segundo archivo comprimido, en esta
 * ocasión probando todas las palabras de un diccionario (el fichero
 * "words.txt" que ya habíamos usando anteriormente). Tendrás un fichero
 * compartido llamado "c2.7z" en Aules y en GitHub, y también tendrás el
 * (des)compresor de línea de comandos "7za.exe" (la orden para descomprimir
 * probando una contraseña "hola" es "7za x c2.7z -phola"). */

using System;
using System.IO;
using System.Diagnostics;

class RomperPassStrings {

    static void Main() {

        string[] palabras;

        palabras = File.ReadAllLines("words.txt");

        for (int i = 0; i < palabras.Length; i++) {
            string contrasenya = palabras[i];
            Console.Write(contrasenya + " ");

            Process process = Process.Start("7za.exe", "x c2.7z -p" + contrasenya);
            process.WaitForExit();

            if (process.ExitCode == 0) {
                Console.WriteLine("Password encontrado: " + contrasenya);
                return;
            }

        }
    }

}
