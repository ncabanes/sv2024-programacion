/* Crea, desde Visual Studio, una clase llamada "Recuadro", cuyos atributos 
 * (privados) serán las coordenadas x e y de comienzo (números enteros), 
 * la anchura y la altura (también enteros) y el carácter con el que se 
 * dibuje ese recuadro (hueco). Crea "getters" y "setters" que permitan 
 * cambiar el valor de los atributos. Tendrá también un método "Dibujar", 
 * que muestre el recuadro en pantalla (usando Console.SetCursorPosition). 
 * Crea, en un segundo fichero fuente, una clase "PruebaDeRecuadro", que 
 * tendrá un "Main", que defina dos recuadros en distintas posiciones, 
 * con distintos tamaños y distintos caracteres de borde, y los dibuje 
 * en pantalla. Entrega todo el proyecto de Visual Studio, comprimido 
 * en un fichero ZIP.
*/

using System;

// ----------------

class PruebaDeRecuadro
{
    static void Main()
    {
        Recuadro r1 = new Recuadro();
        r1.SetX(5);
        r1.SetY(3);
        r1.SetAnchura(20);
        r1.SetAltura(5);
        r1.SetCaracter('X');
        r1.Dibujar();

        Recuadro r2 = new Recuadro();
        r2.SetX(10);
        r2.SetY(5);
        r2.SetAnchura(25);
        r2.SetAltura(15);
        r2.SetCaracter('.');
        r2.Dibujar();
    }
}

// ----------------

class Recuadro
{
    private byte x, y, anchura, altura;
    private char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetAnchura() { return anchura; }
    public int GetAltura() { return altura; }
    public char GetCaracter() { return caracter; }

    public void SetX(int nuevaX) { x = (byte) nuevaX; }
    public void SetY(int nuevaY) { y = (byte) nuevaY; }
    public void SetAnchura(int nuevaAnchura) { anchura = (byte) nuevaAnchura; }
    public void SetAltura(int nuevaAltura) { altura = (byte) nuevaAltura; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }

    public void Dibujar()
    {
        // Primera fila
        for (int i = 0; i < anchura; i++)
        {
            Console.SetCursorPosition(x+i, y);
            Console.WriteLine(caracter);
        }

        // Filas intermedias
        for (int fila  = 1; fila < altura-1; fila++)
        {
            Console.SetCursorPosition(x, y+fila);
            Console.WriteLine(caracter);

            Console.SetCursorPosition(x+anchura-1, y + fila);
            Console.WriteLine(caracter);
        }

        // Ultima fila
        for (int i = 0; i < anchura; i++)
        {
            Console.SetCursorPosition(x + i, y+altura-1);
            Console.WriteLine(caracter);
        }
    }
}

