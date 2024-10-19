/* FRANCISCO (...)
 *
 * 49. Muestra un calendario, pidiendo al usuario la cantidad de días del mes
 (por ejemplo, 31) y el número dentro de la semana que ocupa el primer día (por
 ejemplo, 2 para el martes). El resultado debería ser algo como:
  L  M  X  J  V  S  D
     1  2  3  4  5  6
  7  8  9 10 11 12 13
 14 15 16 17 18 19 20
 21 22 23 24 25 26 27
 28 29 30 31

 */

using System;

class Ejercicio49
{
    static void Main()
    {
        int diasMes, primerDia, caracteres=0;

        Console.WriteLine("¿Cuántos días tiene el mes?");
        diasMes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿Qué día de la semana empieza el mes?");
        primerDia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("  L  M  X  J  V  S  D");// Fila de días de mes

        for (int i=1; i<=(primerDia-1)*3; i++) // Bucle para completar con
        // caracteres hasta empezar el mes según el primerDia
        {
            Console.Write(" ");
            caracteres++;
        }
        for (int j=1; j<=diasMes; j++)// Bucle para días de mes
        {
            if (j<10)// si la cifra < 10, el espacio entre numeros son 2 caracteres
            {
                Console.Write("  {0}", j);
                caracteres+=3;
            }
            else// si la cifra es >10, el espacio entre numeros son 2 caracteres
            {
                Console.Write(" {0}", j);
                caracteres+=3;
            }
            // si la suma de caracteres (numeros y espacios) es >21, hace un salto
            // de línea y reinicia el contador.
            if (caracteres==21)
            {
                Console.WriteLine();
                caracteres=0;
            }
        }
    }
}

