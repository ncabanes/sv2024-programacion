// Pide al usuario el nombre de un fichero WEBP.
// Avísale en caso de que el primer byte no sea una letra R.

using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        FileStream f = File.OpenRead("welcome8.webp");
        int dato = f.ReadByte();
        if (dato == -1)
        {
            Console.WriteLine("Fin de fichero inesperado");
        }
        else 
        { 
            if ((byte) dato == 'R')
                Console.WriteLine("Parece un WEBP");
            else
                Console.WriteLine("No es un WEBP");
        }
        f.Close();
    }
}
