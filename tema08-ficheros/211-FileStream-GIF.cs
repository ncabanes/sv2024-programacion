/* 211. Crea una variante del ejercicio anterior: un programa que pida el 
nombre de un fichero GIF y compruebe si realmente se trata de una imagen en ese 
formato, en esta ocasión con FileStream, leyendo un bloque de 5 bytes. Deberás 
comprobar que los 4 primeros bytes corresponden a los caracteres G, I, F, 8. El 
quinto byte permite saber la versión concreta de fichero GIF del que se trata 
(GIF87 o GIF89), que deberás mostrar en pantalla. Tienes un fichero de ejemplo 
"welcome8.gif" compartido en Aules y GitHub. */

using System;
using System.IO;

class ComprobarGIF
{
    static void Main()
    {
        Console.WriteLine("Introduce el nombre del fichero.");
        string fichero = Console.ReadLine();

        FileStream comprobar = new FileStream(fichero, FileMode.Open);
        comprobar.Seek(0, SeekOrigin.Begin);
        byte[] gif = new byte[5];
        comprobar.Read(gif, 0, gif.Length);
        comprobar.Close();

        if (gif[0] == 'G' && gif[1] == 'I' && gif[2] == 'F' 
            && gif[3] == '8' && gif[4] == '7')
        {
            Console.WriteLine("Se trata de un fichero GIF87.");
        }
        else if (gif[0] == 'G' && gif[1] == 'I' && gif[2] == 'F' 
            && gif[3] == '8' && gif[4] == '9')
        {
            Console.WriteLine("Se trata de un fichero GIF89.");
        }
        else
        {
            Console.WriteLine("Se desconoce el fichero.");
        }
    }
}

