/*
57. Pide un número entero al usuario y calcula su raíz cuadrada con una 
cifra decimal por aproximación, tanteando los valores que sea 
necesario. Por ejemplo, si el usuario introduce 84, el resultado 
debería ser 9,1, porque 9,1 al cuadrado es menor que 84, pero 9,2 al 
cuadrado es mayor que 84.
*/

using System;

class RaizAproximada
{
    static void Main()
    {
        double num;
        double raiz = 0;

        Console.Write("¿De qué número quieres la raíz? ");
        num = Convert.ToDouble(Console.ReadLine());
        
        while (raiz*raiz < num -0.001)
        {
            raiz += 0.1;
        }
        
        // Esta versión es más fiable, porque permite un cierto error
        if ((raiz*raiz >= num - 0.001) && (raiz*raiz <= num + 0.001))
        {
            Console.WriteLine("Raiz exacta: {0}", raiz.ToString("N1"));
        }
        else
        {
            Console.WriteLine("Raiz aproximada: {0}", raiz.ToString("N1"));
        }
    }
}
