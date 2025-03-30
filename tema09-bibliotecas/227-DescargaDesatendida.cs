/*
 Descarga, de forma automatizada, la versión HTML del libro
"Learn Python the Hard Way" (al menos los 52 ejercicios),
desde

https://learnpythonthehardway.org/book/

Por Blanca (,,,)
 */
using System;
using System.IO;
using System.Net;

class DescargaDesatendida
{
    static void Main()
    {
        WebClient client = new WebClient();
        string baseUrl = "https://learnpythonthehardway.org/book/";


        for (int i=0; i<53; i++)
        {
            Stream conexion = client.OpenRead(baseUrl + "ex" + i + ".html");
            StreamReader reader = new StreamReader(conexion);
            StreamWriter writer = new StreamWriter("ex"+i+".html");

            string linea;
            do
            {
                linea = reader.ReadLine();
                if (linea != null)
                {
                    writer.WriteLine(linea);
                }
            } while (linea != null);

            writer.Close();
            reader.Close();
            conexion.Close();
        }
    }
}

