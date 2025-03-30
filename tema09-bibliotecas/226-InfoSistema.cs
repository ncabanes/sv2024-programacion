/* MARTA (...)
 * 
 * Muestra información sobre el sistema: versión de Windows, 
 * versión de Punto Net, nombre de usuario actual, carpeta de 
 * documentos y espacio libre y espacio total en todas las 
 * particiones de disco (quizá necesites buscar información 
 * sobre "DriveInfo")
 * */

using System;
using System.IO;
using System.Diagnostics;

class InfoSistema
{
    static void Main()
    {

        Console.WriteLine("Versión de Windows: " + Environment.OSVersion);

        Console.WriteLine("Versión de Punto NET: " + Environment.Version);

        Console.WriteLine("Nombre de usuario actual: " + Environment.UserName);

        string carpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine("Carpeta de documentos: " + carpetaDocumentos);

        // Espacio libre y total en todas las particiones
        Console.WriteLine("Espacio en las particiones de disco:");
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                Console.WriteLine("Unidad: " + drive.Name);
                Console.WriteLine("  Total: " + drive.TotalSize / 1024 / 1024 + " MB");
                Console.WriteLine("  Libre: " + drive.AvailableFreeSpace / 1024 / 1024 + " MB");
                Console.WriteLine();
            }
        }
    }
}


