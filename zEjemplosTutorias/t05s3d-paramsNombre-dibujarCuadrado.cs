/*
Añade una nueva llamada desde Main a la función anterior, 
con los parámetros en otro orden.
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
        Console.WriteLine();
        DibujarCuadrado(caracter: 'M', lado: 5);
    }
}

