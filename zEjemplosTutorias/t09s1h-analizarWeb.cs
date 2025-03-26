// Muestra las líneas que contienen la palabra
// "daw" en la página principal del IES San Vicente.

using System;
using System.IO;
using System.Net;

class Program
{
    static void Main()
    {
        WebClient client = new WebClient();
        Stream conexion = client.OpenRead("https://www.iessanvicente.com");
        StreamReader lector = new StreamReader(conexion);
        string linea;
        linea = lector.ReadLine();
        while (linea != null)
        {
            if (linea.Contains("daw"))
            {
                Console.WriteLine(linea);
            }
            linea = lector.ReadLine();
        }

        /*
        do
        {
            linea = lector.ReadLine();
            if (linea != null)
                Console.WriteLine(linea);
        }
        while (linea != null);
        */

        lector.Close();
        conexion.Close();

    }
}
