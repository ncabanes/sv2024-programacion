// Muestra el nombre y la fecha de los fuentes
// en C# (ficheros .cs) que hay en la carpeta
// actual.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo[] ficheros = dir.GetFiles("*.cs");
        foreach (FileInfo fich in ficheros)
        {
            //if (fich.Extension == ".cs")
            Console.WriteLine(fich.Name + " " +
                fich.CreationTime);
        }

    }
}
