/*
105. Crea una función llamada "GetMaxMin", que devolverá el máximo y el mínimo 
del array de números reales de doble precisión que se pase como parámetro, 
usando dos parámetros por referencia. Si el array está vacío, no devolverá 
ningún valor, sino que se deberá lanzar una excepción (para lo que no necesitas 
hacer nada especial: el programa fallará al acceder a la posición [0], y será 
un comportamiento aceptable). Crea un Main de prueba.
*/

using System;

class Ejercicio105
{
    static void Main()
    {
        double[] arrayNumeros = { 2.5, -3.5, 1.5, 15, 9.5, 10 };
        double max = 0, min = 0;

        GetMaxMin(arrayNumeros, ref max, ref min);

        Console.WriteLine("El máximo es {0}", max);
        Console.WriteLine("El mínimo es {0}", min);
    }

    static void GetMaxMin(double[] datos, ref double maximo, ref double minimo)
    {
        maximo = datos[0];
        minimo = datos[0];
        
        for (int i = 1; i < datos.Length; i++)
        {
            if (datos[i] > maximo)
            {
                maximo = datos[i];
            }

            if (datos[i] < minimo)
            {
                minimo = datos[i];
            }
        }
    }
}
