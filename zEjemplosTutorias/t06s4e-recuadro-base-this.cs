// Aplica "base" y "this" donde sea necesario en las clases
// Recuadro y RecuadroConSombra de sesiones anteriores.


using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro(3, 4, 5, 3, '*');
        r1.Dibujar();

        RecuadroConSombra r2 = new RecuadroConSombra(6, 5, 20, 10, 'M');
        r2.Dibujar();

        Recuadro r3 = new Recuadro(9, 7);
        r3.Dibujar();
    }
}

// -----------------------

class Recuadro
{
    protected int x, y, anchura, altura;
    protected char caracter;

    public Recuadro(int x, int y,
        int anchura, int altura, char caracter)
    {
        this.x = x;
        this.y = y;
        this.anchura = anchura;
        this.altura = altura;
        this.caracter = caracter;
    }

    public Recuadro(int nuevoX, int nuevoY)
        : this(nuevoX, nuevoY, 40, 10, 'X')
    {
    }

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

    public virtual void Dibujar()
    {
        for (int fila = y; fila < y + altura; fila++)
        {
            for (int columna = x; columna < x + anchura; columna++)
            {
                Console.SetCursorPosition(columna, fila);
                Console.Write(caracter);
            }
        }
    }
}

// -----------------------

class RecuadroConSombra : Recuadro
{
    public RecuadroConSombra(int nuevoX, int nuevoY,
            int nuevaAnchura, int nuevaAltura, 
            char nuevoCaracter)
        : base(nuevoX, nuevoY, nuevaAnchura, nuevaAltura,
            nuevoCaracter)
    {
    }

    public override void Dibujar()
    {
        base.Dibujar();

        // Fila de sombra inferior
        for (int columna = x + 1; columna < x + anchura + 1; columna++)
        {
            Console.SetCursorPosition(columna, y + altura);
            Console.Write('.');
        }

        // Columna de sombra derecha
        for (int fila = y + 1; fila < y + altura + 1; fila++)
        {
            Console.SetCursorPosition(x + anchura, fila);
            Console.Write('.');
        }
    }
}


