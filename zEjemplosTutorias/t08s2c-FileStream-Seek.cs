// Pide al usuario el nombre de un fichero WEBP.
// Lee un bloque de 4 bytes tras saltar los primeros
// 8 bytes. Avísale en caso de que los 4 bytes no
// sean W,E,B,P.


using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        byte[] cabecera = new byte[4];
        FileStream f = File.OpenRead("welcome8.webp");
        if (f.Length < 12)
        {
            Console.WriteLine("No es un WEBP válido");
            return;
        }

        f.Seek(8, SeekOrigin.Begin);
        int cantidadLeida = f.Read(cabecera, 0, 4);
        if (cantidadLeida != 4)
        {
            Console.WriteLine("Error de lectura");
        }
        else 
        {
            if ((cabecera[0] == 'W') && (cabecera[1] == 'E')
                    && (cabecera[2] == 'B') && (cabecera[3] == 'P'))
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
