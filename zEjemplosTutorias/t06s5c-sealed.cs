// Etiqueta la clase Cuadrado como "sellada". Comprueba que no se
// te permite de heredar de ella.

using System;

abstract class FiguraGeometrica
{
    protected int x, y;
    public abstract void Dibujar();
}

// -----------------------
sealed class Cuadrado : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado");
    }
}

// -----------------------
/*
class CuadradoAdornado : Cuadrado
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado adornado");
    }
}
*/

// -----------------------

class PruebaDeFiguras
{
    static void Main()
    {
        Cuadrado cuadrado = new Cuadrado();
        cuadrado.Dibujar();
    }
}
