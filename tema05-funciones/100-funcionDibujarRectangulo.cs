/* 100. Crea una función llamada "DibujarRectangulo", que mostrará un 
rectángulo con el ancho, la altura y el carácter que se indiquen como 
parámetros. Añade un "Main" de prueba. La función deberá aparecer después de 
"Main". */

using System;

class Ejercicio100
{
    static void Main()
    {
        int altura, ancho;
        char caracter;

        Console.Write("Dime el ancho: ");
        ancho = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime la altura: ");
        altura = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime el carácter: ");
        caracter = Convert.ToChar(Console.ReadLine());

        DibujarRectangulo(ancho, altura, caracter);
    }

    static void DibujarRectangulo(int ancho, int alto, char letra)
    {
        for (int fila = 1; fila <= alto; fila++)
        {
            for (int columna = 1; columna <= ancho; columna++)
            {
                Console.Write(letra);
            }
            Console.WriteLine();
        }
    }
}
