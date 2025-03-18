// Pide al usuario el nombre de un fichero WEBP.
// Usando BinaryReader, lee 4 bytes tras saltar
// los primeros 8 bytes. Avísale en caso de que los
// 4 bytes no sean W,E,B,P.

using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        BinaryReader f = new BinaryReader(
            File.Open("welcome8.webp", FileMode.Open));
        f.BaseStream.Seek(8, SeekOrigin.Begin);
        byte c1, c2, c3, c4;
        c1 = f.ReadByte();
        c2 = f.ReadByte();
        c3 = f.ReadByte();
        c4 = f.ReadByte();

        if ((c1 == 'W') && (c2 == 'E')
                    && (c3 == 'B') && (c4 == 'P'))
        {
            Console.WriteLine("Es un WEBP");
        }
        else
        {
            Console.WriteLine("No es un WEBP");
        }

        f.Close();
    }
}
