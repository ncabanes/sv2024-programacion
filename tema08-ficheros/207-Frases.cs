// Alejandro (...)

/*207. Crea una nueva versión del ejercicio 185 (lista de strings), partiendo de la versión oficial, 
 * en la que guardes datos al salir y cargues datos (si existen) al comenzar la ejecución.
 * Puedes emplear StreamWriter y StreamReader o alguna otra alternativa que te parezca adecuada. 
 * Debes gestionar los posibles errores de forma adecuada.*/


using System;
using System.Collections.Generic;
using System.IO;

class ListaFrases
{
    static void Main()
    {
        const string SALIR = "S", AGREGAR = "1", VER = "2", BUSCAR = "3",
            MODIFICAR = "4", BORRAR = "5";

        List<string> frases = Cargar();
        string opcion;
        bool terminar = false;

        do
        {

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

            switch (opcion)
            {
                case AGREGAR:
                    Console.Write("Introduce una frase: ");
                    string cadena = Console.ReadLine();
                    if (cadena != "")
                    {
                        frases.Add(cadena);
                    }
                    LimpiarPantalla();
                    break;

                case VER:
                    foreach (string c in frases)
                    {
                        Console.WriteLine(c);
                    }
                    LimpiarPantalla();
                    break;

                case BUSCAR:
                    bool encontrado = false;
                    Console.Write("Texto a buscar: ");
                    string textoBuscar = Console.ReadLine().ToLower();
                    foreach (string t in frases)
                    {
                        if (t.ToLower().Contains(textoBuscar))
                        {
                            Console.WriteLine("Encontrado: " + t);
                            encontrado = true;
                        }
                    }
                    if (!encontrado)
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

        Guardar(frases);
    }

    private static List<string> Cargar()
    {
        List<string> frases = new List<string>();

        if (!File.Exists("frases.dat"))
        {
            return frases;
        }

        try
        {
            StreamReader fichero = new StreamReader("frases.dat");
            int cantidad = Convert.ToInt32(fichero.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                frases.Add(fichero.ReadLine());
            }

            fichero.Close();
        }
        catch (IOException)
        {
            Console.WriteLine("Error de lectura");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        return frases;
    }

    private static void Guardar(List<string> frases)
    {
        try
        {
            StreamWriter fichero = new StreamWriter("frases.dat");
            fichero.WriteLine(frases.Count);
            foreach (string frase in frases)
            {
                fichero.WriteLine(frase);
            }
            fichero.Close();
        }

        catch (IOException)
        {
            Console.WriteLine("Error de escritura");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }


    private static void LimpiarPantalla()
    {
        Console.WriteLine();
        Console.Write("Pulsa una tecla para continuar ... ");
        Console.ReadKey();
        Console.Clear();
    }
}
