/* 212. Crea un programa que permita copiar un archivo de origen a un archivo 
de destino. El nombre de ambos ficheros se tomará de la línea de comandos. 
Debes usar FileStream y un bloque con el tamaño de todo el archivo. Un ejemplo 
de uso podría ser:

micopiador fichero1.txt e:\fichero2.txt

Debe comportarse correctamente si el archivo de origen no existe y debe avisar 
(pero no sobrescribirlo) si el archivo de destino existe. */

using System;
using System.IO;

class Copiador
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Error, uso: micopiador fichero_origen fichero_destino");
        }

        string origen = args[0];
        string destino = args[1];
        
        if (!File.Exists(origen))
        {
            Console.WriteLine("El fichero de origen no existe.");
        }
        else if (File.Exists(destino))
        {
            Console.WriteLine("El fichero de destino ya existe.");
        }
        else
        {
            FileStream archivoOrigen = File.OpenRead(origen);
            int tamanyo = (int) archivoOrigen.Length;
            byte[] cabecera = new byte[tamanyo];
            int cantidadLeida = archivoOrigen.Read(cabecera, 0, tamanyo);
            archivoOrigen.Close();
            
            if (cantidadLeida != tamanyo)
            {
                Console.WriteLine("No se ha podido leer todo el fichero");
            }
            else
            {
                FileStream archivoDestino = File.Create(destino);
                archivoDestino.Write(cabecera, 0, tamanyo);
                archivoDestino.Close();
                Console.WriteLine("Archivo copiado correctamente");
            }
        }
    }
}
