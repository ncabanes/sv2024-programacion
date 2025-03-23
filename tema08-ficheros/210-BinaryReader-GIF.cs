/* 210. Crea un programa que pida el nombre de un fichero GIF y compruebe si 
realmente se trata de una imagen en ese formato. En esta primera versión debes 
hacerlo con BinaryReader, leyendo byte a byte, y comprobando que los 4 primeros 
bytes corresponden a los caracteres G, I, F, 8. El quinto byte permite saber la 
versión concreta de fichero GIF del que se trata (GIF87 o GIF89), que deberás 
mostrar en pantalla. Tienes un fichero de ejemplo "welcome8.gif" compartido en 
Aules y GitHub. */

using System;
using System.IO;

class GifBinaryReader
{
    static void Main()
    {
        Console.Write("Nombre del fichero: ");
        string nombre = Console.ReadLine();
        
        try
        {
            FileStream f = File.OpenRead(nombre);

            byte byte1 = (byte)f.ReadByte();
            byte byte2 = (byte)f.ReadByte();
            byte byte3 = (byte)f.ReadByte();
            byte byte4 = (byte)f.ReadByte();
            byte byte5 = (byte)f.ReadByte();

            f.Close();

            if (byte1 == 'G' && byte2 == 'I' &&
                byte3 == 'F' && byte4 == '8')
            {
                Console.WriteLine("Es un GIF versión: {0}", 
                    Convert.ToChar(byte5));
            }
            else
            {
                Console.WriteLine("No es un GIF");
            }
        }
        catch (IOException)
        {
            Console.WriteLine("No se ha podido abrir");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
