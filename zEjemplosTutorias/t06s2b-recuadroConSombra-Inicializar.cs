// Crea una nueva versión de la clase Recuadro, que incluya un
// método "Inicializar (x, y, ancho, alto, carácter)", que
// permita dar a la vez los valores iniciales para todos los
// atributos. Pruébalo desde "Main".


using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro();
        r1.Inicializar(3, 4, 5, 3, 'X');
        r1.Dibujar();

        RecuadroConSombra r2 = new RecuadroConSombra();
        r2.Inicializar(6, 5, 20, 10, 'M');
        r2.Dibujar();
    }
}

// -----------------------

class Recuadro
{
    protected int x, y, anchura, altura;
    protected char caracter;

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

    public void Inicializar(int nuevoX,int nuevoY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter) 
    {
        x = nuevoX;
        y = nuevoY;
        anchura = nuevaAnchura;
        altura = nuevaAltura;
        caracter = nuevoCaracter; 
    }

    public void Dibujar()
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
    public void Dibujar()
    {
        for (int fila = y; fila < y + altura; fila++)
        {
            for (int columna = x; columna < x + anchura; columna++)
            {
                Console.SetCursorPosition(columna, fila);
                Console.Write(caracter);
            }
        }

        // Fila de sombra inferior
        for (int columna = x + 1; columna < x + anchura + 1; columna++)
        {
            Console.SetCursorPosition(columna, y + altura);
            Console.Write('.');
        }

        // Columna de sombra derecha
        for (int fila = y+1; fila < y + altura + 1; fila++)
        {
            Console.SetCursorPosition(x + anchura, fila);
            Console.Write('.');
        }
    }
}

//   XXXXX
//   XXXMMMMMMMMMMMMMMMMMMMM
//   XXXMMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMMMMMMMMMMMMMMMMMM.
//       ....................
