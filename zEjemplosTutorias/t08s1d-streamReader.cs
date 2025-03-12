// Lee el primero de los tres ficheros que has creado en
// el ejercicio anterior y muestra su contenido.

using System;
using System.IO;
using System.Runtime.CompilerServices;

class Ejemplo
{
    static void Main()
    {
        StreamReader fichero = File.OpenText("1.txt");
        string linea;
        do
        {
            linea = fichero.ReadLine();
            if (linea != null)
            {
                Console.WriteLine(linea);
            }
        }
        while (linea != null);
        fichero.Close();
    }
}
