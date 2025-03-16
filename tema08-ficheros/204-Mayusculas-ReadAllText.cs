/* 204. Crea un programa en C# que lea el contenido de un fichero de 
texto en una sola pasada, con File.ReadAllText. Luego convierte ese 
texto a mayúsculas y guárdalo en otro fichero con la orden 
"File.WriteAllText (nombreFichero, texto);". El nombre del fichero de 
texto de entrada se tomará de la línea de comandos. El nombre del 
fichero de salida será el mismo que el de entrada, añadiéndole 
".mays.txt". Debes comprobar los posibles errores con try-catch.*/

using System;
using System.IO;

class FicheroAMayusculas
{
    static void Main(string[] args)
    {
        try
        {
            string texto = File.ReadAllText(args[0]);
            File.WriteAllText(args[0] + ".mays.txt", texto.ToUpper());
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("Ruta demasiado larga");
        }
        catch(IOException)
        {
            Console.WriteLine("No se ha podido leer o escribir");
        }
        catch(Exception)
        {
            Console.WriteLine("Error. Recuerde indicar el nombre de fichero");
        }
    }
}
