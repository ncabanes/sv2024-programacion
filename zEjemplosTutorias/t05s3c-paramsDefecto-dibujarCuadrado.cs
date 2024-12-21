/*
Crea una función DibujarCuadrado, que dibuje un cuadrado
relleno en consola. Recibirá el tamaño del lado y, 
opcionalmente, el carácter a utilizar (se tomará un 
asterisco si no se indica otro)

Pruébala desde Main.
*/

using System;

class Ejemplo
{
    static void DibujarCuadrado(int lado=4, char caracter='*')
    {
        for (int fila = 0; fila < lado; fila++) 
        {
            for (int columna = 0; columna < lado; columna++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        DibujarCuadrado(6);
        Console.WriteLine();
        DibujarCuadrado(12, '#');
        Console.WriteLine();
        DibujarCuadrado();
    }
}

