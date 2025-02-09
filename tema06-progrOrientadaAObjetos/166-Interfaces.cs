/*----------------------------------------------

Damián (...)
Desarrollo de Aplicaciones Multiplataforma (DAM)
Tema 6
Ejercicio 166
Interface IDibujable, IMedible

------------------------------------------------*/
using System;

interface IDibujable
{
    void Dibujar();
}

interface IMedible
{
    int GetArea();
}

class RectanguloEnPantalla : IDibujable, IMedible
{
    private int X1 { get; set; }
    private int Y1 { get; set; }
    private int X2 { get; set; }
    private int Y2 { get; set; }

    public RectanguloEnPantalla(int x1, int y1, int x2, int y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public void Dibujar()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        for(byte fila = (byte)X1; fila < X2; fila++)
        {   
            Console.SetCursorPosition(Y1,fila);
            for(byte col = (byte)Y1; col < Y2; col++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public int GetArea()
    {
        return (X2-X1)*(Y2-Y1);
    }
}

class PruebaDeRectangulo
{
    static void Main()
    {
        RectanguloEnPantalla rectangulo = new RectanguloEnPantalla(2, 2, 10, 30);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(rectangulo.GetArea());
        rectangulo.Dibujar();
        Console.ResetColor();
    }
}
