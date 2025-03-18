// Pide al usuario el nombre de un fichero WEBP.
// Lee el primer bloque de 12 bytes. Avísale en caso
// de que los bytes 9 a 12 no sean W,E,B,P.

using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        byte[] cabecera = new byte[12];
        FileStream f = File.OpenRead("welcome8.webp");
        
        int cantidadLeida = f.Read(cabecera, 0, 12);
        if (cantidadLeida != 12)
        {
            Console.WriteLine("Error de lectura");
        }
        else 
        {
            if ((cabecera[8] == 'W') && (cabecera[9] == 'E')
                    && (cabecera[10] == 'B') && (cabecera[11] == 'P'))
            {
                Console.WriteLine("Es un WEBP");
            }
            else
            {
                Console.WriteLine("No es un WEBP");
            }
        }

        f.Close();
    }
}
