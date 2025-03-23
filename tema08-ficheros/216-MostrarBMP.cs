//Alejandro (...)

/*216. [Tiempo máximo recomendado: 40 minutos] Mostrar un BMP en consola.

Crea un programa que sea capaz de mostrar una imagen en blanco y negro en formato
BMP de 256 colores en la consola, como el archivo de ejemplo que tienes compartido, llamado "welcome8.bmp".

Puedes leer el ancho (bytes 18 a 21) y el alto (bytes 22 a 25) de la imagen, ya sea usando BinaryReader 
(cada uno es un entero de 32 bits) o FileStream (de la forma que puedes ver en la página 24 de los apuntes del tema 8).

Los bytes 10 a 13 (que también forman un Int32) se pueden usar para saber en qué posición
del fichero comienzan los datos de la imagen. Como alternativa, ya que cada píxel corresponde 
a un byte, puedes situarte a "-ancho*alto" desde el final del archivo y comenzar a leer desde ahí. 

Debes dibujar un "." si el valor del píxel es > 127, o un "*" en caso contrario.
*/


using System;
using System.IO;

class Ejercicio216
{
    static void Main()
    {
        FileStream imagen = new FileStream("welcome8.bmp", FileMode.Open);
        int tamanyo = (int)imagen.Length;
        byte[] datos = new byte[tamanyo];
        imagen.Read(datos, 0, tamanyo);
        imagen.Close();

        byte ancho = datos[18];
        byte alto = datos[22];
        int inicioImagen = datos[10] + 256 * datos[11];

        byte[,] imagenAMostrar = new byte[alto, ancho];

        int i = 0;

        for (int fila = 0; fila < alto; fila++)
        {
            for (int columna = 0; columna < ancho; columna++)
            {
                byte pixel = datos[inicioImagen + i];
                imagenAMostrar[alto - fila - 1, columna] = pixel;
                i++;

            }

        }

        for (int fila = 0; fila < alto; fila++)
        {
            for (int columna = 0; columna < ancho; columna++)
            {
                byte pixel = imagenAMostrar[fila, columna];
                if (pixel > 127)
                    Console.Write(".");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}


