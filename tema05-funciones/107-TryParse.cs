/*
107. Crea una función "SumaDigitos(n)", que devuelva la suma de los dígitos de 
un entero largo que reciba como parámetro (puedes tomar la última cifra cada 
vez con n%10, y luego eliminarla con n = n/10). Pruébala desde Main, para un 
dato introducido por el usuario. Para gestionar los errores de introducción de 
datos, no debes usar "try-catch" sino "TryParse" (apartado 5.7.4 de los 
apuntes).
*/

using System;

class Ejercicio107
{
    static long SumaDigitos (long n)
    {
        long suma = 0;

        while (n > 0)
        {
            byte cifra = (byte) (n % 10);
            n /= 10;
            suma += cifra;
        }
        return suma; 
    }
    
    static void Main()
    {
        long numero;

        Console.Write("Dime un número: ");

        if (Int64.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("La suma de los dígitos de {0} es: {1}",
                numero, SumaDigitos(numero));
        }
        else
        {
            Console.WriteLine("Número no válido");
        }
    }
}
