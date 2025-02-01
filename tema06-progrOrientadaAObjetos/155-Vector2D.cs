/* 155. Crea una clase Vector2D que represente un vector en el espacio 
bidimensional (con coordenadas X, Y). Debe tener:

- Un constructor, que permita dar valores de X, Y.

- Setters y getters en formato convencional.

- Un método "ToString", que devolvería algo como "<2.5, -3>"

- Un método "GetModulo" que devuelva la longitud (módulo) del vector (raíz 
  cuadrada de x^2 + y^2)

- Un método "Sumar", que permita sumar un vector (que se pasará como parámetro) 
  al actual (el resultado será la suma componente a componente: <x1 + x2, y1 + 
  y2>)

Crea un programa de prueba, en otra clase distinta, que permita probar estas 
funcionalidades. */

using System;

class Vector2D
{
    private double x;
    private double y;

    public Vector2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double GetX() {return x; }
    public double GetY() {return y; }

    public void SetX(double x) { this.x = x; }
    public void SetY(double y) { this.y = y; }

    public override string ToString()
    {
        return "<" + x + ", " + y + ">";
    }

    public double GetModulo()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public void Sumar(Vector2D v)
    {
        x += v.x;
        y += v.y;
    }
}

class PruebaVector2D
{
    static void Main()
    {
        Vector2D v = new Vector2D(10, 15);
        Vector2D v2 = new Vector2D(2.5, -17);
        v.Sumar(v2);
        Console.WriteLine(v);
        Console.WriteLine("El módulo de v es " + v.GetModulo());
    }
}
