/* 149.A partir de la "solución oficial" del esqueleto de PacMan (ejercicio 141)
 * , ya sea en su versión como proyecto o en un único fichero, añade un método 
 * Mover a la clase Sprite, que inicialmente estará vacío. Crea cuatro subtipos
 * de fantasmas, cada uno con un movimiento distinto. Por ejemplo, la clase 
 * FantasmaAzul puede moverse hacia la derecha, la clase FantasmaNaranja hacia 
 * la izquierda, el FantasmaRojo hacia arriba y el FantasmaRosa hacia abajo. 
 * Cada vez que el jugador pulse una tecla, no sólo se moverá Pac, sino también 
 * los cuatro fantasmas (que aún no serán parte de un array). Recuerda: en cada
 * subtipo de fantasma sólo existirá el método Mover, no debes crear métodos 
 * adicionales, sino que la lógica de ese método "Mover" será distinta en cada 
 * subclase.
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
    
    public void Mover()
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

    public new void Mover()
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

    public new void Mover()
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

    public new void Mover()
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

    public new void Mover()
    {
        MoverAbajo();
    }
}

// ------------------------

class PruebaDeSprite
{
    static void Main()
    {
        FantasmaAzul azul = new FantasmaAzul(0, 0);
        FantasmaNaranja naranja = new FantasmaNaranja(20, 0);
        FantasmaRojo rojo = new FantasmaRojo(0, 20);
        FantasmaRosa rosa = new FantasmaRosa(20, 20);
        Pac pacman = new Pac(10, 10);

        ConsoleKeyInfo tecla;
        do
        {
            pacman.Dibujar();
            azul.Dibujar();
            rojo.Dibujar();
            naranja.Dibujar();
            rosa.Dibujar();

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

            azul.Mover();
            naranja.Mover();
            rojo.Mover();
            rosa.Mover();

            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
}

