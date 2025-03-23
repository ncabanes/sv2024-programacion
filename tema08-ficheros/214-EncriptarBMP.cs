/* 214. Crea un programa que sea capaz de encriptar y desencriptar una imagen 
en formato BMP, intercambiando el orden de sus dos primeros bytes de modo que 
los visores de imágenes no la detecten como una imagen válida. Debes abrir el 
fichero para lectura y escritura simultánea. Tienes un fichero de ejemplo 
"welcome8.bmp" compartido en Aules y GitHub. */

using System;
using System.IO;

class EncriptarBMP
{
    static void Main(string[] args)
    {
        try
        {
            string nombre = args[0];
            FileStream fichero = File.Open(nombre, FileMode.Open, 
                FileAccess.ReadWrite);
            byte[] datos = new byte[2];
            int cantidadLeida = fichero.Read(datos, 0, 2);

            fichero.Seek(0, SeekOrigin.Begin);
            fichero.WriteByte(datos[1]);
            fichero.WriteByte(datos[0]);

            Console.WriteLine(
                "Fichero \'{0}\' (des)encriptado correctamente.", nombre);

            fichero.Close();
        }
        catch (IOException)
        {
            Console.WriteLine("No se ha podido leer / escribir");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
