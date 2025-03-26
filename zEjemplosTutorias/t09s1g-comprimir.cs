// Comprime los ficheros de la carpeta actual,
// lanzando el compresor "rar" (o "7z") de línea
// de comandos. 

//Deberás usar una orden como "rar a datos *.*"
//(o, en el caso de 7z, "7z a datos *.*").

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process p = Process.Start("rar.exe", "a comprimido *.cs");
        p.WaitForExit();
        if (p.ExitCode != 0 )
        {
            Console.WriteLine("Algo no ha funcionado");
        }
    }
}
