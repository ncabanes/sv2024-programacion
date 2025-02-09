/* 163.Crea una clase Vector3D que represente un vector en el espacio
 * tridimensional (con coordenadas X, Y, Z, que serán números reales de doble
 * precisión). Debe tener:

-Un constructor que permita inicializar los valores de X, Y, Z.

- En vez de emplear atributos y setters+getters convencionales, deberás
utilizar propiedades en formato compacto.

- Un método "ToString", que devolvería algo como "<2, -3, 4.2>" (es decir,
los valores X, Y, Z, separados por ", ", precedidos por un símbolo de "menor
que" y terminando con un símbolo de "mayor que").

-Un método "GetModulo", que permita obtener la longitud (módulo) del vector
(la raíz cuadrada de x^2 + y^2 + z^2)

-Un método "Sumar", que permita sumar un vector (que se pasará como parámetro)
al vector actual (el resultado será: < x1 + x2, y1 + y2, z1 + z2 >)

Crea un programa de prueba, que permita probar estas funcionalidades.

Luis (...)  */

using System;

class PruebaVector
{
    static void Main()
    {
        Vector3D v1 = new Vector3D(25,-4,44);
        Vector3D v2 = new Vector3D(10,5,22);

        Console.WriteLine("Vector 1: " + v1);
        Console.WriteLine("Vector 2: " + v2);

        Console.WriteLine("Módulo del vector1: " + v1.GetModulo());
        Console.WriteLine("Módulo del vector2: " + v2.GetModulo());

        v1.Sumar(v2);
        Console.WriteLine("Suma del vector2 al vector1: " + v1);
    }
}

//--------------------

public class Vector3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return "<" + X + ", " + Y + ", " + Z +">";
    }

    public double GetModulo()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public void Sumar(Vector3D nuevoVect)
    {
        X += nuevoVect.X;
        Y += nuevoVect.Y;
        Z += nuevoVect.Z;
    }
}
