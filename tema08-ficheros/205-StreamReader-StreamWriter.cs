/* 205. Crea un programa que pregunte al usuario el nombre de un fichero 
de texto de entrada, el nombre de salida, y vuelque el contenido del 
primero al segundo, excepto las líneas vacías. Debes emplear 
StreamReader y StreamWriter, comprobando los posibles errores con 
try-catch. El programa debe pedir confirmación en caso de que el 
fichero de salida ya exista. */

using System;
using System.IO;

class SinLineasVacias
{
    static void Main()
    {
        Console.Write("Fichero a leer? ");
        string nombreEntrada = Console.ReadLine();
        Console.Write("Fichero a escribir? ");
        string nombreSalida = Console.ReadLine();
        
        if(File.Exists(nombreSalida))
        {
            Console.Write("El fichero \"{0}\" ya existe. Sobreescribir? [S/N]: ", 
                nombreSalida);
            if(Console.ReadLine().ToUpper() != "S")
            {
                Console.WriteLine("Cancelado!");
                return;
            }
        }
 
        try
        {
            StreamReader lectura = File.OpenText(nombreEntrada);            
            StreamWriter escritura = File.CreateText(nombreSalida);

            string linea;
            do
            {
                linea = lectura.ReadLine();
                if ((linea != null) && (linea != ""))
                    escritura.WriteLine(linea);
            } while (linea != null);
            
            escritura.Close();
            lectura.Close();
            Console.WriteLine("Volcado completado");
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("La ruta del fichero es demasiado larga");
        }
        catch(IOException)
        {
            Console.WriteLine("Error de lectura / escritura");
        }
        catch(Exception e)
        {
            Console.WriteLine("Error procesando datos: {0}", e.Message);
        }
    }
}
