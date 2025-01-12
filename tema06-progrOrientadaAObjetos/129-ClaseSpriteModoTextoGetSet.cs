/*
Crea una nueva versión de la clase "SpriteModoTexto". Sus atributos no serán públicos,
sino que tendrá "getters" y "setters" que permitan cambiar el valor de éstos. Además, 
tendrá un método "MoverDerecha" que incrementará la X en una unidad y otro "MoverIzquierda",
que la disminuirá en una unidad. Modifica el programa y "Main" según sea necesario. 
*/

// Blanca (...)

using System;

class SpriteModoTexto
{
    private int x, y;
    private char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    public void SetX(int setx) { x= setx; }
    public void SetY(int sety) { y= sety; }
    public void SetCaracter(char c) { caracter = c; }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }
    public void MoverDerecha()
    {
        x = x+1;
    }

    public void MoverIzquierda()
    {
        x = x-1;
    }
}
class PruebaDeSprite
{
    static void Main()
    {
        SpriteModoTexto t = new SpriteModoTexto();
        t.SetX(40);
        t.SetY(10);
        t.SetCaracter('M');
        t.Dibujar();
        t.MoverDerecha();
        t.Dibujar();
    }
}

