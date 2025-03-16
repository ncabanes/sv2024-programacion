/* 203. Crea un programa en C# que lea el contenido de un fichero de 
texto y lo vuelque a otro fichero, ordenando sus líneas alfabéticamente 
y eliminando las líneas duplicadas. Usa File.ReadAllLines y 
File.WriteAllLines, junto con las estructuras dinámicas que consideres 
adecuadas. El nombre del fichero de texto de entrada se debe preguntar 
al usuario. El nombre del fichero de salida será el mismo que el de 
entrada, añadiéndole ".ordenado.txt". En esta versión no es necesario 
que compruebes los posibles errores con try-catch.*/

using System;
using System.Collections.Generic;
using System.IO;

class OrdenarSinDuplicados
{
    static void Main()
    {
        Console.Write("Nombre del archivo: ");
        string archivo = Console.ReadLine();

        SortedSet<string> lineas = new SortedSet<string>(File.ReadAllLines(archivo));
        File.WriteAllLines(archivo + ".ordenado.txt", lineas);
    }
}
