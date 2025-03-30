/* 224. Intenta romper la contraseña de un archivo comprimido, lanzando un 
descompresor y verificando si el valor devuelto es 0. Tendrás un fichero 
compartido llamado "c.rar" en Aules y en GitHub, cuya contraseña es un número 
de 4 cifras (entre 0000 y 9999), y también tendrás el (des)compresor de línea 
de comandos "rar.exe" (la orden para descomprimir el fichero "c.rar" probando 
una contraseña "1234" sería "rar x c.rar -p1234").

Autor: Paul (...)
*/

using System;
using System.Diagnostics;

class RompeContrasenya
{
    static void Main()
    {
        string archivoComprimido = "cb.rar";
        string rarRuta = "rar.exe";

        for (int i = 0; i <= 9999; i++)
        {
            string contrasenya = i.ToString("D4");
            Console.WriteLine("Probando contraseña: " + contrasenya);

            if(ProbarContrasenya(rarRuta, archivoComprimido, contrasenya))
            {
                Console.WriteLine("Contraseña encontrada! Es: " + contrasenya);
                return;
            }
        }

        Console.WriteLine("NO se ha encontrado la contraseña");
    }


    static bool ProbarContrasenya(string rarRuta, string archivoComprimido, string contytrasenya)
    {
        try
        {
            string comando = "x " + archivoComprimido + "-p" + contytrasenya;
            Process proceso = Process.Start(rarRuta, comando);
            proceso.WaitForExit();

            return proceso.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }
}
