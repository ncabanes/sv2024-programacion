/*141. Crea un esqueleto mejorado para el juego de PacMan: el nuevo Main 
permitirá mover a Pac se pulsen las flechas del teclado, para lo que puedes 
tomar ideas del siguiente fragmento de código:

ConsoleKeyInfo tecla = Console.ReadKey();

if (tecla.Key == ConsoleKey.LeftArrow)
    pac.MoverIzquierda();
else if (tecla.Key == ConsoleKey.RightArrow)
    pac.MoverDerecha();

Este esqueleto deberá repetirse hasta que se pulse la tecla Escape. Te 
interesará borrar la pantalla con Console.Clear(); */

// Joaquín, retoques menores por Nacho

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

class Fantasma : SpriteModoTexto
{
    public Fantasma(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'A';
    }
}

class Pac : SpriteModoTexto
{
    public Pac(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
        caracter = 'C';
    }
}

class PruebaDeSprite
{
    static void Main()
    {
        
        Fantasma azul = new Fantasma(0, 0);
        Fantasma rojo = new Fantasma(20, 0);
        Fantasma amarillo = new Fantasma(0, 20);
        Fantasma blanco = new Fantasma(20, 20);
        Pac pacman = new Pac(10, 10);

        ConsoleKeyInfo tecla;
        do
        {
            pacman.Dibujar();
            azul.Dibujar();
            rojo.Dibujar();
            amarillo.Dibujar();
            blanco.Dibujar();
        
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
            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
}
