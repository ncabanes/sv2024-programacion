/* 139. Crea una nueva versión de la clase SpriteModoTexto (ejercicio 129), con 
un constructor que permita dar valores iniciales para x, y, carácter. Los 
atributos deben pasar a ser "protected". Usa este constructor desde Main, en 
vez de los setters. */

// Joaquín

using System;

class SpriteModoTexto
{
    protected int x, y;
    protected char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    public void SetX(int setx) { x = setx; }
    public void SetY(int sety) { y = sety; }
    public void SetCaracter(char c) { caracter = c; }

    public SpriteModoTexto(int nuevoX, int nuevoY, char nuevoCaracter)
    {
        x = nuevoX;
        y = nuevoY;
        caracter = nuevoCaracter;
    }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }
    public void MoverDerecha()
    {
        x = x + 1;
    }

    public void MoverIzquierda()
    {
        x = x - 1;
    }
}

class PruebaDeSprite
{
    static void Main()
    {
        SpriteModoTexto t = new SpriteModoTexto(40,10,'M');
        t.Dibujar();
    }
}

