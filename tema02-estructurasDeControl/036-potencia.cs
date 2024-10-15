// Juan Carlos (...)

/* 36. Crea un programa que pida al usuario dos números enteros y muestre su potencia
 * (el primero elevado al segundo), empleando multiplicaciones repetitivas.
 * Recuerda que 3 ^ 4 = 3 * 3 * 3 * 3 (es decir, para elevar 3 a la cuarta potencia,
 * deberás multiplicar por 3 cuatro veces) = 81. */

using System;

class ejercicio36
{
    static void Main()
    {
        Console.Write("Introduce la base de la potencia: ");
        int basePotencia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el exponente: ");
        int exponente = Convert.ToInt32(Console.ReadLine());

        int potencia = 1;

        for(int i = 0; i < exponente; i++)
        {
            potencia *= basePotencia;
        }

        Console.Write($"El resultado es: {potencia}");
    }
}
