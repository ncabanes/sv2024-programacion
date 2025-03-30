/* 219. Crea un programa llamado "logger", que, cada vez que se lance, añadirá 
una línea a un archivo de texto llamado "log.txt".  Esta línea contendrá la 
fecha y hora actuales, en formato DD-MM-AA HH:MM:SS.mmm ,seguida por el texto 
que el usuario haya indicado como parámetros de la línea de comandos. Por 
ejemplo, si el ejecutable se llama "logger.exe" y el usuario escribe "logger 
Esto es una prueba" en la línea de comandos, se debe añadir una línea como:

24-03-25 17:20:02.023 - Esto es una prueba

Si no se indica nada en línea de comandos, se preguntará al usuario qué texto 
desea anotar, y se añadirá ese texto (junto con la fecha y hora actual) al 
final del "log". */

using System;
using System.IO;

class Logger
{
    static void Main(string[] args)
    {
        string detalles;
        if (args.Length > 0)
        {
            detalles = string.Join(" ", args);
        }
        else
        {
            Console.Write("¿Qué texto desea anotar como parte del registro?: ");
            detalles = Console.ReadLine();
        }

        DateTime fechaActual = DateTime.Now;
        detalles = fechaActual.ToString("dd-MM-yy HH:mm:ss.fff")
            + " - " +detalles;

        try
        {
            using (StreamWriter ficheroRegistros = File.AppendText("log.txt"))
            {
                ficheroRegistros.WriteLine(detalles);
            }

            Console.WriteLine("Anotado");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error en la escritura: {0}", e.Message);
        }
    }
}
