// 68. Escribe un programa que pida al usuario 5 números reales de doble 
// precisión y muestre su máximo, mínimo, suma y media.

// Rubén (...)

using System;

class Ejercicio68
{
    static void Main()
    {
        Console.Write("Introduce el numero 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el numero 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el numero 3: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el numero 4: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el numero 5: ");
        double num5 = Convert.ToDouble(Console.ReadLine());

        double min = num1;
        double max = num1;

        if (num2 < min) min = num2;
        if (num3 < min) min = num3;
        if (num4 < min) min = num4;
        if (num5 < min) min = num5;

        if (num2 > max) max = num2;
        if (num3 > max) max = num3;
        if (num4 > max) max = num4;
        if (num5 > max) max = num5;

        double suma = num1+num2+num3+num4+num5;
        double media = (num1+num2+num3+num4+num5) / 5;

        Console.WriteLine("Max = {0}, Min = {1}, Suma = {2}, Media = {3}", 
            max, min, suma, media.ToString("0.000"));
    }
}

