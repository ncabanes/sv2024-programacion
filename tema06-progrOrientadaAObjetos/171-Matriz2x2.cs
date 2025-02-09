/*----------------------------------------------

Damián (...)
Desarrollo de Aplicaciones Multiplataforma (DAM)
Tema 6
Ejercicio 171
Matriz2x2

------------------------------------------------*/
using System;

class Matriz2x2
{
    private float[,] matriz = new float[2,2];

    public Matriz2x2(float f1a, float f1b, float f2a, float f2b)
    {
        matriz[0, 0] = f1a;
        matriz[0, 1] = f1b;
        matriz[1, 0] = f2a;
        matriz[1, 1] = f2b;
    }

    public Matriz2x2()
    {
        matriz[0, 0] = 0;
        matriz[0, 1] = 0;
        matriz[1, 0] = 0;
        matriz[1, 1] = 0;
    }

    public float Get(int fila, int columna)
    {
        return matriz[fila, columna];
    }

    public void Set(int fila, int columna, float valor)
    {
        matriz[fila, columna] = valor;
    }

    public void Multiplicar(float valor)
    {
        matriz[0, 0] *= valor;
        matriz[0, 1] *= valor;
        matriz[1, 0] *= valor;
        matriz[1, 1] *= valor;
    }

    public void Sumar(Matriz2x2 matriz2)
    {
        matriz[0, 0] += matriz2.Get(0, 0);
        matriz[0, 1] += matriz2.Get(0, 1);
        matriz[1, 0] += matriz2.Get(1, 0);
        matriz[1, 1] += matriz2.Get(1, 1);
    }

    public static Matriz2x2 operator +(Matriz2x2 matriz1, Matriz2x2 matriz2)
    {
        Matriz2x2 resultado = new Matriz2x2();

        resultado.Set(0, 0, matriz1.Get(0, 0) + matriz2.Get(0, 0));
        resultado.Set(0, 1, matriz1.Get(0, 1) + matriz2.Get(0, 1));
        resultado.Set(1, 0, matriz1.Get(1, 0) + matriz2.Get(1, 0));
        resultado.Set(1, 1, matriz1.Get(1, 1) + matriz2.Get(1, 1));

        return resultado;
    }

    public override string ToString()
    {
        return matriz[0, 0] + " " + matriz[0, 1] + "\n" + matriz[1, 0] + " " + matriz[1, 1];
    }

    public void Mostrar()
    {
        Console.WriteLine("(" + matriz[0, 0] + "   "+ matriz[0, 1] + ")");
        Console.WriteLine("(" + matriz[1, 0] + "   "+ matriz[1, 1] + ")");
        Console.WriteLine();
    }
}

class PruebaDeMatriz
{
    static void Main()
    {
        Matriz2x2 matrizA = new Matriz2x2();
        Matriz2x2 matrizB = new Matriz2x2();

        IngresarDatos(matrizA, "A");
        IngresarDatos(matrizB, "B");

        matrizB.Multiplicar(3);

        
        Matriz2x2 matrizC = matrizA + matrizB;

        ImprimirMatriz(matrizA, "Matriz A");
        Console.WriteLine("B*3 =");
        ImprimirMatriz(matrizB, "Matriz B");
        Console.WriteLine("A + B*3 =");
        ImprimirMatriz(matrizC, "Matriz C");
    }

    static void IngresarDatos(Matriz2x2 matriz, string nombre)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Ingrese el elemento (" + i + ", " + j + ") de la matriz " + nombre + ": " );
                matriz.Set(i, j, float.Parse(Console.ReadLine()));
            }
        }
    }

    static void ImprimirMatriz(Matriz2x2 matriz, string mensaje)
    {
        matriz.Mostrar();
    }
}
