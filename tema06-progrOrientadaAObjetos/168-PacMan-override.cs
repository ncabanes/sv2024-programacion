/* 168. Mejora el esqueleto de PacMan (ejercicio 167), con estos tres detalles:

- En vez de emplear "is" para comprobar el tipo de cada fantasma, haz que el
color cambie en el método dibujar de la propia clase Fantasma (y derivadas).

- Mejora las lógicas de movimiento para que no se salgan de ciertos límites
(por ejemplo, una Y negativa actualmente provocará que el programa falle).

- Añade a la clase SpriteModoTexto un método booleano "ColisionaCon(otroSprite)"
, que te permita saber si dos elementos del juego chocan (basta con que mires
si coinciden su X y su Y). Úsalo en el cuerpo del programa para que el juego
termine si un fantasma toca al jugador.

Luis (...) , retoques menores por Nacho */

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
        bool gameOver = false;
        do
        {
            pacman.Dibujar();
            foreach (Fantasma fantasma in fantasmas)
            {
                fantasma.Dibujar();
            }

            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow) pacman.MoverIzquierda();
            else if (tecla.Key == ConsoleKey.RightArrow) pacman.MoverDerecha();
            else if (tecla.Key == ConsoleKey.UpArrow) pacman.MoverArriba();
            else if (tecla.Key == ConsoleKey.DownArrow) pacman.MoverAbajo();

            foreach (Fantasma fantasma in fantasmas)
            {
                fantasma.Mover();
                if (fantasma.ColisionaCon(pacman))
                    gameOver = true;
            }

            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape && !gameOver);

        Console.WriteLine("¡Juego terminado!.");
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

    public virtual void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
        Console.ResetColor();
    }

    public void MoverDerecha() { if (x < Console.WindowWidth - 1) x++; }
    public void MoverIzquierda() { if (x > 0) x--; }
    public void MoverArriba() { if (y > 0) y--; }
    public void MoverAbajo() { if (y < Console.WindowHeight - 1) y++; }

    public bool ColisionaCon(SpriteModoTexto otro)
    {
        return this.x == otro.x && this.y == otro.y;
    }
}
// ------------------------------------

class Fantasma : SpriteModoTexto
{
    public Fantasma(int x, int y) : base(x, y, 'A') { }
    public Fantasma() : this(10, 10) { }
    public virtual void Mover() { }
}

// ------------------------------------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(int x, int y) : base(x, y) { }
    public FantasmaAzul() : this(5, 5) { }
    public override void Mover() { MoverDerecha(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Dibujar();
    }
}

// ------------------------------------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(int x, int y) : base(x, y) { }
    public FantasmaNaranja() : this(15, 5) { }
    public override void Mover() { MoverIzquierda(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        base.Dibujar();
    }
}

// ------------------------------------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(int x, int y) : base(x, y) { }
    public FantasmaRojo() : this(5, 15) { }
    public override void Mover() { MoverArriba(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Dibujar();
    }
}

// ------------------------------------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(int x, int y) : base(x, y) { }
    public FantasmaRosa() : this(15, 15) { }
    public override void Mover() { MoverAbajo(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        base.Dibujar();
    }
}

// ------------------------------------

class Pac : SpriteModoTexto
{
    public Pac(int x, int y)
        : base(x, y, 'C')
    {
    }
    
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.Dibujar();
    }
}
