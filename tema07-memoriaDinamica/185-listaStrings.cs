/* Nombre: Andrés (...=
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 185. Frases en lista de strings.
 * 
 * Crea un programa que muestre un menú que permita al usuario introducir
 * frases (de una en una, y se guardarán en una lista de strings), ver todas
 * ellas, buscar las que contengan un cierto texto, modificar una de ellas
 * (indicando su posición) o borrar una de ellas (a partir de su posición). */

using System;
using System.Collections.Generic;

class ListaFrases {

    static void Main() {

        const string SALIR = "S", AGREGAR = "1", VER = "2", BUSCAR = "3",
            MODIFICAR = "4", BORRAR = "5";

        List<string> frases = new List<string> ();

        string opcion ;
        bool terminar = false;

        do {

            Console.WriteLine(" *** MENÚ DE OPCIONES *** ");
            Console.WriteLine();
            Console.WriteLine(AGREGAR + ". Introducir frase.");
            Console.WriteLine(VER + ". Ver todas las frases.");
            Console.WriteLine(BUSCAR + ". Buscar texto.");
            Console.WriteLine(MODIFICAR + ". Modificar una frase.");
            Console.WriteLine(BORRAR + ". Borrar una frase.");
            Console.WriteLine(SALIR + ". Terminar el programa.");
            Console.WriteLine();
            Console.Write("Introduce una opcion: ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcion) {
                case AGREGAR:
                    Console.Write("Introduce una frase: ");
                    string cadena = Console.ReadLine();
                    if (cadena != "") {
                        frases.Add(cadena);
                    }
                    LimpiarPantalla();
                    break;

                case VER:
                    foreach (string c in frases) {
                        Console.WriteLine(c);
                    }
                    LimpiarPantalla();
                    break;

                case BUSCAR:
                    bool encontrado = false;
                    Console.Write("Texto a buscar: ");
                    string textoBuscar = Console.ReadLine().ToLower();
                    foreach (string t in frases) {
                        if (t.ToLower().Contains(textoBuscar)) {
                            Console.WriteLine("Encontrado: " + t);
                            encontrado = true;
                        }
                    }
                    if (! encontrado)
                        Console.WriteLine("No encontrado");
                    LimpiarPantalla();
                    break;

                case MODIFICAR:
                    Console.Write("Número de frase a modificar: ");
                    int nFraseModificar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nuevo texto: ");
                    string nuevoTexto = Console.ReadLine();

                    frases[nFraseModificar - 1] = nuevoTexto;
                    LimpiarPantalla();
                    break;

                case BORRAR:
                    Console.Write("Número de frase a borrar: ");
                    int nFraseBorrar = Convert.ToInt32(Console.ReadLine());
                    frases.RemoveAt(nFraseBorrar - 1);
                    LimpiarPantalla();
                    break;

                case SALIR:
                    Console.WriteLine("Bye bye ...");
                    terminar = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (!terminar);
    }

    private static void LimpiarPantalla() {
        Console.WriteLine();
        Console.Write("Pulsa una tecla para continuar ... ");
        Console.ReadKey();
        Console.Clear();
    }
}
