/* 158. Crea una nueva versión del ejercicio 150 (PacMan 4), a partir de la 
"solución oficial", en la que emplees "this" en los constructores para no 
necesitar parámetros como "nuevaX", no haya ningún constructor sin parámetros, 
y los constructores se apoyen unos en otros usando "base". Main no debe 
cambiar. */

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

    public SpriteModoTexto(int x, int y, char caracter)
    {
        this.x = x;
        this.y = y;
        this.caracter = caracter;
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
    public Fantasma(int x, int y)
        :base(x, y, 'A')
    {
    }

    public virtual void Mover()
    {
    }
}

// ------------------------

class Pac : SpriteModoTexto
{
    public Pac(int x, int y)
        : base(x, y, 'C')
    {
    }
}

// ------------------------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(int x, int y)
        : base(x,y)
    {
    }

    public override void Mover()
    {
        MoverDerecha();
    }
}

// ------------------------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(int x, int y)
        : base(x,y)
    {
    }

    public override void Mover()
    {
        MoverIzquierda();
    }
}

// ------------------------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(int x, int y)
        : base(x, y)
    {
    }

    public override void Mover()
    {
        MoverArriba();
    }
}

// ------------------------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(int x, int y)
        : base(x, y)
    {
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

