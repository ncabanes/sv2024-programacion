/*
105. Crea una función llamada "GetMaxMin", que devolverá el máximo y el mínimo 
del array de números reales de doble precisión que se pase como parámetro, 
usando dos parámetros por referencia. Si el array está vacío, no devolverá 
ningún valor, sino que se deberá lanzar una excepción (para lo que no necesitas 
hacer nada especial: el programa fallará al acceder a la posición [0], y será 
un comportamiento aceptable). Crea un Main de prueba.

106. Crea una variante del ejercicio anterior (105), que no use parámetros 
"ref", sino parámetros "out".
*/

using System;

class Ejercicio106
{
    static void GetMaxMin(double[] nums, out double max, out double min)
    {
        max = min = nums[0];

        for (int n = 1; n < nums.Length; n++)
        {
            if (max < nums[n]) { max = nums[n]; }
            if (min > nums[n]) { min = nums[n]; }
        }
    }

    static void Main()
    {
        double maximo, minimo;

        double[] numeros = { 2.5, -3.5, 1.5, 15, 9.5, 10 };
        GetMaxMin(numeros, out maximo, out minimo);
        Console.WriteLine("Max: " + maximo + "; Min: " + minimo);
    }
}
