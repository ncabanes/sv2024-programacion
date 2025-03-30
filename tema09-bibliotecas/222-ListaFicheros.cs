/*
 Crea un programa que muestre la lista de ficheros que hay en una cierta ruta que 
se indique en línea de comandos (o en la carpeta del ejecutable, 
si no se indica nada en línea de comandos). Para cada fichero, mostrará su nombre, extensión, 
tamaño en KB (destacando los millares, si es el caso) y fecha de modificación, 
con el siguiente formato:

ejemplo.exe, 1.234 KB, 22-Mar-2025
ejemplo.dat, 67 KB, 23-Mar-2025

Por Blanca (...)
 */
using System;
using System.IO;

class ListaDeFicheros
{
    static void Main(string[] args)
    {
        string ruta;

        if(args.Length > 0)
        {
            ruta = args[0];
        }else
        {
            ruta = Environment.CurrentDirectory;
        }

        DirectoryInfo informacionDirectorio = new DirectoryInfo(ruta);

        FileInfo[] ficheros = informacionDirectorio.GetFiles();

        foreach( FileInfo file in ficheros)
        {
            Console.WriteLine(file.Name + " - " + file.Extension
                + " - " + (file.Length / 1024) + "kb - " + file.LastWriteTime);
        }
    }
}

