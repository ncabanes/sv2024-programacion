// Mejora el ejercicio anterior, para que, además,
// cada segundo se mueva una posición hacia arriba,
// comenzando desde la fila 20.

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int x = 30, y = 20;
        bool terminado = false;

        do
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("X");

            Console.SetCursorPosition(40, 1);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now);

            Thread.Sleep(1000);
            if (y > 0) y--;

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.RightArrow)
                    x++;
                else if (tecla.Key == ConsoleKey.LeftArrow)
                    x--;
                else if (tecla.Key == ConsoleKey.Escape)
                    terminado = true;
            }
        }
        while ( ! terminado );

    }
}
