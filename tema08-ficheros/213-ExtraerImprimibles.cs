/* 213. Crea un programa que extraiga los caracteres imprimibles (código ASCII 
32 a 127, además del 9, el 10 y el 13) de un fichero y los vuelque a otro 
fichero. El nombre del fichero de origen se tomará de la línea de comandos y el 
de destino se creará añadiendo ".txt" al nombre de origen. Para la lectura, 
debes usar FileStream y un bloque de 1 KiB (1024 bytes) de tamaño. Para la 
salida puedes emplear StreamWriter, BinaryWriter o escribir byte a byte con un 
FileStream. Si el fichero de destino ya existe, lo sobreescribirás sin 
preguntar. Puedes probarlo (por ejemplo) con los ficheros documento.doc y 
customer.dbf que tienes compartidos en Aules y GitHub. */

using System;
using System.IO;

class ExtraerImprimibdles
{
    static void Main(string[] args)
    {
        if(args.Length > 0) 
        {         
            const int TAMANYO_BLOQUE = 1024;
            string ficheroEntrada = args[0];
            string ficheroSalida = ficheroEntrada + ".txt";

            FileStream lectura;
            FileStream escritura;

            if(File.Exists(ficheroEntrada))
            {
                lectura = File.OpenRead(ficheroEntrada);
                escritura = File.Create(ficheroSalida);

                byte[] datos = new byte[TAMANYO_BLOQUE];
                int bytesLeidos;

                do
                {
                    bytesLeidos = lectura.Read(datos, 0, TAMANYO_BLOQUE);
                    
                    for(int i = 0; i < bytesLeidos; i++)
                    {
                        byte caracter = datos[i];
                        if ((caracter >= 32 && caracter <= 127) || 
                            caracter == 9 || caracter == 10 || caracter == 13)
                        {
                            escritura.WriteByte(caracter);
                        }
                    }
                }
                while (bytesLeidos == TAMANYO_BLOQUE);

                lectura.Close();
                escritura.Close();
            }
            else
            {
                Console.WriteLine("No existe el fichero");
            }
        }
        else
        {
            Console.WriteLine("Debes indicar un parámetro");
        }
    }
}

