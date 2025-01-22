// Crea una variante de la clase Recuadro, empleando
// propiedades (en formato corto) en vez de "getters"
// y "setters" convencionales.

using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro(3, 4, 5, 3, '*');
        r1.X = 2;
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
    private int anchura;

    public int X { get; set; }
    public int Y { get; set; }
    public int Altura { get; set; }
    public int Anchura 
    {
        get { return anchura; }
        set 
        { 
            anchura = value;
            if (anchura < 1) anchura = 1;
        }
    }
    public char Caracter { get; set; }

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
        X = nuevoX;
        Y = nuevoY;
        Anchura = nuevaAnchura;
        Altura = nuevaAltura;
        Caracter = nuevoCaracter;
    }

    public Recuadro(int nuevoX, int nuevoY)
    {
        X = nuevoX;
        Y = nuevoY;
        Anchura = 40;
        Altura = 10;
        Caracter = 'X';
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


//  *****
//  ****MMMMMMMMMMMMMMMMMMMM
//  ****MMMMMMMMMMMMMMMMMMMM.
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
