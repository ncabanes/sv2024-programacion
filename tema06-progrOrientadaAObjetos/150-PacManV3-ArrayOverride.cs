/* 150. Crea una nueva versión del fuente de Pac y los 4 fantasmas 
 * (ejercicio 151), en el que los 4 fantasmas sean parte de un único array. 
 * Comprueba que se mueven correctamente (y soluciónalo, si no es así).
 * 
 * Luis (...), retoques menores por Nacho  */

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

    public SpriteModoTexto()
    {
    }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
    }

    public void MoverDerecha()
    {
        x++;
    }

    public void MoverIzquierda()
    {
        x--;
    }

    public void MoverArriba()
    {
        y--;
    }

    public void MoverAbajo()
    {
        y++;
    }
}

// ------------------------

class Fantasma : SpriteModoTexto
{
    public Fantasma(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }

    public Fantasma()
    {
        caracter = 'A';
    }
    
    public virtual void Mover()
    {

    }
}

// ------------------------

class Pac : SpriteModoTexto
{
    public Pac(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'C';
    }
}

// ------------------------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
    }

    public override void Mover()
    {
        MoverDerecha();
    }
}

// ------------------------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
    }

    public override void Mover()
    {
        MoverIzquierda();
    }
}

// ------------------------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
    }

    public override void Mover()
    {
        MoverArriba();
    }
}

// ------------------------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
    }

    public override void Mover()
    {
        MoverAbajo();
    }
}

// ------------------------

class PruebaDeSprite
{
    static void Main()
    {
        Fantasma[] fantasmas = new Fantasma[4];

        fantasmas[0] = new FantasmaAzul(0, 0);
        fantasmas[1] = new FantasmaNaranja(20, 0);
        fantasmas[2] = new FantasmaRojo(0, 20);
        fantasmas[3] = new FantasmaRosa(20, 20);
        Pac pacman = new Pac(10, 10);

        ConsoleKeyInfo tecla;
        do
        {
            pacman.Dibujar();
            foreach (Fantasma fantasma in fantasmas)
            {
                fantasma.Dibujar();
            }

            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                pacman.MoverIzquierda();
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                pacman.MoverDerecha();
            }
            else if (tecla.Key == ConsoleKey.UpArrow)
            {
                pacman.MoverArriba();
            }
            else if (tecla.Key == ConsoleKey.DownArrow)
            {
                pacman.MoverAbajo();
            }

            foreach (Fantasma fantasma in fantasmas)
            {
                fantasma.Mover();
            }

            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape);

    }
}

