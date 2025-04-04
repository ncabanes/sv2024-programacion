﻿/* 195. Haz una variante más del ejercicio anterior: Crea un diccionario simple 
de inglés a español: el programa deberá contener al menos 10 palabras 
prefijadas. Mostrará un menú que permita añadir una nueva palabra (junto con su 
traducción), buscar la traducción de una palabra, ver la lista de todas las 
palabras (en inglés) almacenadas o salir. Crea esta tercera versión con un 
Dictionary<string,string>. */

using System;
using System.Collections.Generic;

class Ejercicio193
{
    static string MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1 - Añadir nueva palabra.");
        Console.WriteLine("2 - Buscar traducción de una palabra.");
        Console.WriteLine("3 - Ver la lista de todas las palabras almacenadas.");
        Console.WriteLine("S - Salir.");
        Console.WriteLine();
        Console.Write("Seleccione una opción: ");
        return Console.ReadLine().ToUpper();
    }


    static void Main()
    {
        Dictionary<string, string> diccio = new Dictionary<string, string>();
        bool salir = false;
        string palabraIng, palabraEsp;
        diccio.Add("one", "uno");
        diccio.Add("two", "dos");
        diccio.Add("three", "tres");
        diccio.Add("four", "cuatro");
        diccio.Add("five", "cinco");
        diccio.Add("six", "seis");
        diccio.Add("seven", "siete");
        diccio.Add("eight", "ocho");
        diccio.Add("nine", "nueve");
        diccio.Add("ten", "diez");

        do
        {

            switch (MostrarMenu())
            {
                case "1":
                    Console.Write("Deme la palabra inglesa a añadir: ");
                    palabraIng = Console.ReadLine();
                    Console.Write("Deme la traducción a español: ");
                    palabraEsp = Console.ReadLine();
                    if (diccio.ContainsKey(palabraIng))
                    {
                        Console.WriteLine("La palabra {0}, ya está en el " +
                            "diccionario.", palabraIng);
                    }
                    else
                    {
                        diccio.Add(palabraIng, palabraEsp);
                        Console.WriteLine("Palabra añadida.");
                    }
                    break;

                case "2":
                    Console.Write("Deme la palabra en ingles que desea" +
                        " traducir: ");
                    palabraIng = Console.ReadLine();
                    if (diccio.ContainsKey(palabraIng))
                    {
                        Console.WriteLine("La traducción de {0} → {1}",
                            palabraIng, diccio[palabraIng]);
                    }
                    else
                    {
                        Console.WriteLine("La palabra {0} no está en el " +
                            "diccionario.", palabraIng);
                    }
                    break;

                case "3":
                    foreach (KeyValuePair<string, string> dato in diccio)
                    {
                        Console.WriteLine("{0} → {1}",
                        dato.Key, dato.Value);
                    }
                    break;

                case "S":
                    Console.WriteLine("Adios ...");
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opcion no válida.");
                    break;
            }

        } while (!salir);
    }
}

