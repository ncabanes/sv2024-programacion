/*140. Para un esqueleto de juego de PacMan en modo consola, crea una clase Fantasma, que herede de SpriteModoTexto y 
 * cuyo constructor sólo recibirá los valores de X e Y, y prefijará el carácter a "A". Crea una clase Pac, 
 * que también herede de SpriteModoTexto y cuyo constructor sólo recibirá los valores de X e Y, y prefijará el carácter a "C". 
 * El primer Main de prueba creará un Pac y 4 Fantasmas, con coordenadas adecuadas, y los mostrará en pantalla. 
 * Probablemente, necesitarás crear un constructor vacío en SpriteModoTexto; mejoraremos ese detalle más adelante.
*/

//Joaquín

using System;

class SpriteModoTexto
{
    protected int x, y;
    protected char caracter;

    public SpriteModoTexto(int nuevoX, int nuevoY, char nuevoCaracter)
    {
        x = nuevoX;
        y = nuevoY;
        caracter = nuevoCaracter;
    }
    
    public SpriteModoTexto()
    {
    }    

    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    public void SetX(int setx) { x = setx; }
    public void SetY(int sety) { y = sety; }
    public void SetCaracter(char c) { caracter = c; }

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

        pacman.Dibujar();
        azul.Dibujar();
        rojo.Dibujar();
        amarillo.Dibujar();
        blanco.Dibujar();
    }
}
