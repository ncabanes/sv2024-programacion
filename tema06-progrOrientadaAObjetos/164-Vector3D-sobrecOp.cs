/* 164. Crea una nueva versión de la clase Vector3D, sobrecargando el operador
 * "+", de modo que permita sumar dos vectores pasados como parámetros, de modo
 * que se pueda hacer "vector1 = vector2+vector3;". Sobrecarga también el
 * operador "*", para que se pueda multiplicar el vector por un cierto número:
 * "vector1 = vector2 * 7.4;" (el resultado será un nuevo vector, cuyas
 * componentes X, Y y Z estarán multiplicadas por ese número; por ejemplo,
 * para el vector <2, 1.5, -4>, si se multiplica por el número 3, obtendríamos
 * <6, 4.5, -12>).
 *
 * Luis (...)  */

using System;

class PruebaVector2
{
    static void Main()
    {

        Vector3D v1 = new Vector3D(2, -3, 4.2);
        Vector3D v2 = new Vector3D(1.5, 2.5, -1);


        Console.WriteLine("Vector 1: " + v1);
        Console.WriteLine("Vector 2: " + v2);


        Console.WriteLine("Módulo de Vector 1: " + v1.GetModulo());
        Console.WriteLine("Módulo de Vector 2: " + v2.GetModulo());

        Vector3D v3 = v1 + v2;
        Console.WriteLine("Resultado de la suma: " + v3);


        Vector3D v4 = v1 * 7.4;
        Console.WriteLine("Vector 1 multiplicado por 7.4: " + v4);
    }
}

// --------------------------

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
        return "<" + X + ", " + Y + ", " + Z + ">";
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

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator *(Vector3D v, double num)
    {
        return new Vector3D(v.X * num, v.Y * num, v.Z * num);
    }
}

