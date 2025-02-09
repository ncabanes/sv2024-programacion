/* 167. Crea una nueva versión de PacMan (ejercicio 158), partiendo de la 
 * solución oficial, con los siguientes cambios:

- La clase Sprite debe ser abstracta.

- Cada subtipo de fantasma debe tener un constructor vacío, que prefije unas
ciertas coordenadas, además del constructor que recibe X e Y, para simplificar
Main.

- Para practicar el uso de "is", cambia el color desde Main antes de dibujar
cada tipo de fantasma, según el tipo al que pertenezca. Podrás emplear c
onstrucciones como "Console.ForegroundColor = ConsoleColor.Red;".

Luis (...)  */

using System;

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
                if (fantasma is FantasmaRojo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (fantasma is FantasmaAzul)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }             
                else if (fantasma is FantasmaNaranja)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (fantasma is FantasmaRosa)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                fantasma.Dibujar();
                Console.ResetColor();
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

// ------------------------------------

abstract class SpriteModoTexto
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

// ------------------------------------

class Fantasma : SpriteModoTexto
{
    public Fantasma(int x, int y)
        : base(x, y, 'A')
    {
    }
    public Fantasma() : this(10,10) { }

    public virtual void Mover()
    {
    }
}

// ------------------------------------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(int x, int y)
        : base(x, y)
    {
    }
    public FantasmaAzul()
        : this(5,5)
    {
    }
    public override void Mover()
    {
        MoverDerecha();
    }
}

// ------------------------------------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(int x, int y)
        : base(x, y)
    {
    }
    public FantasmaNaranja()
        : this(15,5)
    {
    }
    public override void Mover()
    {
        MoverIzquierda();
    }
}

// ------------------------------------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(int x, int y)
        : base(x, y)
    {
    }
    public FantasmaRojo()
        : this(5, 15)
    {
    }
    public override void Mover()
    {
        MoverArriba();
    }
}

// ------------------------------------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(int x, int y)
        : base(x, y)
    {
    }
    public FantasmaRosa()
        : this(15, 15)
    {
    }
    public override void Mover()
    {
        MoverAbajo();
    }
}

// ------------------------------------

class Pac : SpriteModoTexto
{
    public Pac(int x, int y)
        : base(x, y, 'C')
    {
    }
}
