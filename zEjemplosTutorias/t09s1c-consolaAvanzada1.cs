// Muestra una letra X en pantalla, que se pueda mover
// hacia izquierda y derecha con las flechas del cursor.


using System;

class Program
{
    static void Main()
    {
        int x = 30, y = 12;
        bool terminado = false;

        do
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("X");
            
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.RightArrow)
                x++;
            else if (tecla.Key == ConsoleKey.LeftArrow)
                x--;
            else if (tecla.Key == ConsoleKey.Escape) 
                terminado = true;
        }
        while ( ! terminado );

    }
}
