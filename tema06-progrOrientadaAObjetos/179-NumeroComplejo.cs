/* 179. Los números complejos son una extensión de los números reales, 
que se emplean en muchas ramas avanzadas de las matemáticas (por 
ejemplo, en distintos sectores de la ingeniería) y que recuerdan mucho 
a un "vector en dos dimensiones", porque están formados por dos 
números, llamados su "parte real" y su "parte imaginaria". En un número 
de la forma a + bi (2-3i, por ejemplo), la parte real sería "a" (2) y 
la parte imaginaria sería "b" (-3).

Crea una clase NumeroComplejo con:

- Un constructor que permita fijar los valores para la parte real y la 
parte imaginaria.

- Setters y getters para ambos (llamados SetReal, SetImag y así 
sucesivamente).

- Un método "ToString", que devolvería "(2, -3)"

- Un método "GetMagnitud" para devolver la magnitud del número complejo 
(raíz cuadrada de a2 + b2)

- Un método "Sumar", para sumar un número complejo (que se pasará como 
parámetro) al actual (el resultado será: la parte real será la suma de 
ambas partes reales, y la parte imaginaria será la suma de ambas partes 
imaginarias)

- Sobrecarga el operador + para poder realizar esta misma operación de 
forma más natural.

Crea un programa de prueba, para probar estas funcionalidades.

*/

using System;

class NumeroComplejo
{
    int real, imag;

    public int GetReal() { return real; }
    public void SetReal(int realPart) { this.real = realPart; }

    public int GetImag() { return imag; }
    public void SetImag(int imagPart) { this.imag = imagPart; }

    public NumeroComplejo(int a, int b)
    {
        this.real = a;
        this.imag = b;
    }

    public override String ToString()
    {
        return "(" + real + ", " + imag +")";
    }

    public double GetMagnitud()
    {
        return Math.Sqrt((real * real) + (imag * imag));
    }

    public void Sumar(NumeroComplejo num2)
    {
        real += num2.real;
        imag += num2.imag;
    }

    public static NumeroComplejo operator +(NumeroComplejo num1,
        NumeroComplejo num2)
    {
        NumeroComplejo resultado = new NumeroComplejo(num1.GetReal() +
            num2.GetReal(), num1.GetImag() + num2.GetImag());

        return resultado;
    }
}

// -------------------

class PruebaNumerosCoplejos
{
    static void Main()
    {
        NumeroComplejo num1 = new NumeroComplejo(2, -3);
        NumeroComplejo num2 = new NumeroComplejo(3, 5);
        NumeroComplejo num3 = new NumeroComplejo(-7, 4);

        Console.WriteLine("N1: " + num1);
        Console.WriteLine("Magnitud: " + num1.GetMagnitud());
        Console.WriteLine("N2: " + num2);

        num1.Sumar(num2);
        Console.WriteLine("N1 tras sumar: " + num1);
        
        Console.WriteLine("N3: " + num3);
        Console.Write("Suma de N1 y N3: ");
        Console.WriteLine(num1 + num3);
    }
}
