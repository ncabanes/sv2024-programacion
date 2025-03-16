/* 206. Crea un "convertidor básico de texto a HTML", que leerá un 
archivo de texto de origen y creará un archivo HTML a partir de su 
contenido, añadiendo una cabecera simple (que tendrá el nombre del 
fichero como "title") y tratando cada línea como un párrafo. Por 
ejemplo, si el archivo se llama "fichero.txt" y contiene lo siguiente:

Hola
Soy yo
Ya he terminado

El archivo HTML resultante debe contener

<html>
<head>
  <title>fichero.txt</title>
</head>
<body>
  <p>Hola</p>
  <p>Soy yo</p>
  <p>Ya he terminado</p>
</body>
</html>

El nombre del fichero de entrada se leerá de línea de comandos. Si no 
hay parámetros en línea de comandos, se le preguntará al usuario. El 
fichero de salida tendrá el mismo nombre que el de entrada, pero 
cambiando su extensión (las 3 o cuatro últimas letras, que aparecen 
después del último punto) por ".html". Debes usar StreamReader y 
StreamWriter. Recuerda comprobar los posibles errores de 
funcionamiento.*/


using System;
using System.IO;

class TextoAHtml
{
    static void Main(string[] args)
    {
        string nombreEntrada, nombreSalida, linea;
        StreamReader entrada;
        StreamWriter salida;

        try
        {
            if (args.Length == 0)
            {
                Console.Write("Nombre del fichero de entrada: ");
                nombreEntrada = Console.ReadLine();
            }
            else
            {
                nombreEntrada = args[0];
            }

            nombreSalida = nombreEntrada.Substring(0,
                nombreEntrada.LastIndexOf("."))
                + ".html";

            entrada = new StreamReader(nombreEntrada);
            salida = new StreamWriter(nombreSalida);

            salida.WriteLine("<html>");
            salida.WriteLine("<head>");
            salida.WriteLine("  <title>" +nombreEntrada +"</title>");
            salida.WriteLine("<body>");

            do
            {
                linea = entrada.ReadLine();
                if (linea != null)
                {
                    if (linea != "")
                    {
                        salida.WriteLine("  <p>"+linea+"</p>");
                    }
                }
            }
            while (linea != null);

            salida.WriteLine("</body>");
            salida.WriteLine("</html>");

            entrada.Close();
            salida.Close();
            Console.WriteLine("Generación de HTML terminada");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("ERROR, el fichero no existe");
        }
        catch (IOException)
        {
            Console.WriteLine("ERROR de escritura o entrada");
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: " + e.Message);
        }
    }
}
