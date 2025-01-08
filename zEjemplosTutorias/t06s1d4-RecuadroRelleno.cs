using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        RecuadroRelleno r1 = new RecuadroRelleno();
        r1.SetX(3);
        r1.SetY(4);
        r1.SetAnchura(5);
        r1.SetAltura(3);
        r1.SetCaracter('X');
        r1.Dibujar();

        RecuadroRelleno r2 = new RecuadroRelleno();
        r2.SetX(6);
        r2.SetY(5);
        r2.SetAnchura(20);
        r2.SetAltura(10);
        r2.SetCaracter('.');
        r2.Dibujar();
    }
}

// -----------------------

class RecuadroRelleno
{
    private int x, y, anchura, altura;
    private char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetAnchura() { return anchura; }
    public int GetAltura() { return altura; }
    public char GetCaracter() { return caracter; }

    public void SetX(int nuevoX) { x = nuevoX; }
    public void SetY(int nuevoY) { y = nuevoY; }
    public void SetAnchura(int nuevaAnchura) { anchura = nuevaAnchura; }
    public void SetAltura(int nuevaAltura) { altura = nuevaAltura; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }

    public void Dibujar()
    {
        for (int fila = y; fila < y+altura; fila++)
        {
            for (int columna = x; columna < x+anchura; columna++)
            {
                Console.SetCursorPosition(columna, fila);
                Console.Write(caracter);
            }
        }
    }
}
