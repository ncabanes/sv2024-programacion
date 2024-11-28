/* Crea una función "SumaDeArray", reciba como parámetros un array de 
enteros y devuelva como resultado la suma de los números que forman ese 
array. Pruébala desde Main, con un array prefijado.
*/

using System;

class Ejemplo 
{
    static int SumaDeArray(int[] datos)
    {
        int suma = 0;
        foreach(int d in datos)
            suma += d;
        return suma;
    }
    
    static void Main() 
    {
        int[] numeros = { 5, 10, 12 };
        int suma = SumaDeArray(numeros);
        Console.WriteLine("La suma es " + suma);
    }
}

/*
La suma es 27
*/
