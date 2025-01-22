// Crea un array formado por 3 recuadros, de los cuales 2 serán de la 
// clase Recuadro y 1 será RecuadroConSombra. Dibuja todos ellos. Es de 
// esperar que el recuadro con sombra no se dibuje correctamente, pero lo 
// solucionaremos pronto.


using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro[] recuadros = new Recuadro[3];
        recuadros[0] = new Recuadro(3, 4, 5, 3, '*');
        RecuadroConSombra r2 = new RecuadroConSombra(6, 5, 20, 6, 'M');
        recuadros[1] = r2;
        recuadros[2] = new Recuadro(9, 14);

        for (int i = 0; i < recuadros.Length; i++)
        {
            recuadros[i].Dibujar();
        }
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

    public new void Dibujar()
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




//   *****
//   ***MMMMMMMMMMMMMMMMMMMM
//   ***MMMMMMMMMMMMMMMMMMMM
//      MMMMMMMMMMMMMMMMMMMM
//      MMMMMMMMMMMMMMMMMMMM
//      MMMMMMMMMMMMMMMMMMMM
//      MMMMMMMMMMMMMMMMMMMM
//
//
//
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
//         XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
