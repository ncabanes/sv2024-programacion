// Crea una clase abstracta FiguraGeometrica, con atributos (o propiedades)
// "x" e "y" y con un método abstracto "Dibujar". 

// Comprueba que no te deja instanciar objetos de esa clase.

// Crea una clase Cuadrado, que herede de ella, que añada un
// atributo "lado". Implementa en ella el método "Dibujar"
// (por ejemplo, puedes dibujar cuadrado de ese lado, en esas
// coordenadas de pantalla, con Console.SetCursorPosition, o
// simplemente escribir un texto).


using System;

abstract class FiguraGeometrica
{
    protected int x, y;
    public abstract void Dibujar();
}

// -----------------------
class Cuadrado : FiguraGeometrica
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado");
    }
}

// -----------------------

class PruebaDeFiguras
{
    static void Main()
    {
        Cuadrado cuadrado = new Cuadrado();
        cuadrado.Dibujar();
    }
}
