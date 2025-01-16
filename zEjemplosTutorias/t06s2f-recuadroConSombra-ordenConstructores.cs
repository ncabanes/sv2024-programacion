// Muestra un texto en el constructor de la clase Recuadro
// y otro en RecuadroConSombra, para comprobar en qué orden
// se crean las clases.

using System;

// -----------------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro(3, 4, 5, 3, '*');
        RecuadroConSombra r2 = new RecuadroConSombra(6, 5, 20, 10, 'M');
        Recuadro r3 = new Recuadro(9, 7);

        r1.Dibujar();
        r2.Dibujar();
        r3.Dibujar();
    }
}

// -----------------------

class Recuadro
{
    protected int x, y, anchura, altura;
    protected char caracter;

    public Recuadro()
    {
        /*
        y = 10; x = 10;
        anchura = 40;
        altura = 10;
        caracter = 'W';
        */
        Console.WriteLine("Creando un recuadro vacío");
    }

    public Recuadro(int nuevoX, int nuevoY,
        int nuevaAnchura, int nuevaAltura, char nuevoCaracter)
    {
        x = nuevoX;
        y = nuevoY;
        anchura = nuevaAnchura;
        altura = nuevaAltura;
        caracter = nuevoCaracter;
        Console.WriteLine("Creando un recuadro con todo");
    }

    public Recuadro(int nuevoX, int nuevoY)
    {
        x = nuevoX;
        y = nuevoY;
        anchura = 40;
        altura = 10;
        caracter = 'X';
        Console.WriteLine("Creando un recuadro con 3 datos prefijados");
    }

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
        x = nuevoX;
        y = nuevoY;
        anchura = nuevaAnchura;
        altura = nuevaAltura;
        caracter = nuevoCaracter;
        Console.WriteLine("Creando un recuadro con sombra");
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

//Creando un recuadro con todo
//Creando un recuadro vacío
//Creando un recuadro con sombra
//Creando un recuadro con 3 datos prefijados
//   *****
//   ***MMMMMMMMMMMMMMMMMMMM
//   ***MMMMMMMMMMMMMMMMMMMM.
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
