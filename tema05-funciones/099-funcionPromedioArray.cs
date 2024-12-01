/* 99. Crea una función llamada "Promedio", que devolverá el promedio de los 
elementos de un array de enteros que se pasará como parámetro. Pruébala con un 
array prefijado. La función deberá aparecer antes de "Main".*/

using System;

class Ejercicio99
{
    static float Promedio(int[] numeros)
    {
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma += numeros[i];
        }

        float promedio = (float) suma / numeros.Length;
        return promedio;
    }
    
    static void Main()
    {
        int[] datos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine( Promedio(datos) );
    }
}
