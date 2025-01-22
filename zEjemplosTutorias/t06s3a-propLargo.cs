// Crea una variante de la clase Recuadro, empleando propiedades 
// (en formato largo) en vez de "getters" y "setters" convencionales. 
// Haz que los atributos sean privados, en vez de protegidos, de modo 
// que la clase RecuadroConSombra use las propiedades, en vez de los 
// atributos. Además, desde Main, cambia la X y el carácter del primer
// rectángulo usando propiedades.

using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro(3, 4, 5, 3, '*');
        r1.X = 7;
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
    private int x, y, anchura, altura;
    private char caracter;

    public Recuadro()
    {
        /*
        y = 10; x = 10;
        anchura = 40;
        altura = 10;
        caracter = 'W';
        */
    }

    public Recuadro(int nuevoX, int nuevoY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        x = nuevoX;
        y = nuevoY;
        anchura = nuevaAnchura;
        altura = nuevaAltura;
        caracter = nuevoCaracter;
    }

    public Recuadro(int nuevoX, int nuevoY)
    {
        x = nuevoX;
        y = nuevoY;
        anchura = 40;
        altura = 10;
        caracter = 'X';
    }

    public int X { get { return x; } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }

    public int Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public int Anchura
    {
        get { return anchura; }
        set { anchura = value; }
    }

    public char Caracter
    {
        get { return caracter; }
        set { caracter = value; }
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
    public RecuadroConSombra(int nuevoX, int nuevoY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        X = nuevoX;
        Y = nuevoY;
        Anchura = nuevaAnchura;
        Altura = nuevaAltura;
        Caracter = nuevoCaracter;
    }

    public void Dibujar()
    {
        for (int fila = Y; fila < Y + Altura; fila++)
        {
            for (int columna = X; columna < X + Anchura; columna++)
            {
                Console.SetCursorPosition(columna, fila);
                Console.Write(Caracter);
            }
        }

        // Fila de sombra inferior
        for (int columna = X + 1; columna < X + Anchura + 1; columna++)
        {
            Console.SetCursorPosition(columna, Y + Altura);
            Console.Write('.');
        }

        // Columna de sombra derecha
        for (int fila = Y + 1; fila < Y + Altura + 1; fila++)
        {
            Console.SetCursorPosition(X + Anchura, fila);
            Console.Write('.');
        }
    }
}

//       *****
//      MMMMMMMMMMMMMMMMMMMM
//      MMMMMMMMMMMMMMMMMMMM.
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//      MMMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//       ..XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
